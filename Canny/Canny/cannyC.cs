using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Canny
{
    class cannyC
    {
        // thuật toán biên màu thành gray xám để dễ dang phát hiện điểm ảnh
        public Bitmap MakeGrayscale(Bitmap original)
        {
            try
            {
                Color originalColor;
                Color newColor;
                Bitmap newBitmap = new Bitmap(original.Width, original.Height);

                for (int i = 0; i < original.Width; i++)
                    for (int j = 0; j < original.Height; j++)
                    {
                        // lấy các pixel ảnh từ ảnh gốc 
                        originalColor = original.GetPixel(i, j);
                        // trong mỗi pixel sẽ tạo ra một màu xám. kiểu từ pixel ảnh sẽ phủ màu xám tới từng điểm ảnh pixel đó
                        int grayScale = (int)((originalColor.R * 0.3) + (originalColor.G * 0.59) + (originalColor.B * 0.11));
                        newColor = Color.FromArgb(grayScale, grayScale, grayScale);
                        newBitmap.SetPixel(i, j, newColor);
                    }
                return newBitmap;
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        // Làm mịn điểm ảnh == bitmap là các điểm ảnh
        // bitmap nó chính là các pixel ảnh
        public Bitmap MakeSmooth(Bitmap original)
        {

            int runningSum = 0;
            int tempSum = 0;
            int xcoord;
            int ycoord;
            Color newColor;
            // phương thức này như một ma trận == nó đồng bộ điểm ảnh
            int[,] kernel = new int[5, 5] 
            {
                    {1, 4, 7, 4, 1},
                    {4, 16, 26, 16, 4},
                    {7, 26, 41, 26, 7},
                    {4, 16, 26, 16, 4},
                    {1, 4, 7, 4, 1}
            };
            Color[,] pixels = new Color[5, 5];

            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            // đi đến mọi pixel ảnh
            for (int i = 0; i < original.Width; i++)
                for (int j = 0; j < original.Height; j++)
                {
                    // Với các điểm ảnh
                    // đặt các pixel vào trong ma trận 5*5  chia điểm ảnh trong ma trận 5*5
                    for (int x = -2; x < 3; x++)
                        for (int y = -2; y < 3; y++)
                        {
                            // offset xcoord and ycoord
                            xcoord = i + x;
                            ycoord = j + y;

                            // kiểm tra xem các điểm ảnh có nằm ngoài giới hạn của nó hay không 
                            // rổi phản xạ các điểm ảnh nằm ngoài giới hạn
                            if (xcoord < 0 || xcoord > original.Width - 1)
                                xcoord = i - x;
                            if (ycoord < 0 || ycoord > original.Height - 1)
                                ycoord = j - y;

                            // gán màu cho các pixel ảnh với ma trận 5*5
                            pixels[x + 2, y + 2] = original.GetPixel(xcoord, ycoord);
                        }

                    // Nhân các giá trị trong ma trận
                    // add giá trị tempSum
                    for (int k = 0; k < 5; k++)
                        for (int l = 0; l < 5; l++)
                            tempSum += kernel[k, l] * pixels[k, l].R;
                    // chia nó cho 273
                    runningSum = tempSum / 273;
                    // đó là màu mới của nó
                    newColor = Color.FromArgb(runningSum, runningSum, runningSum);
                    // Xét màu đó cho từng giá trị điểm anh
                    newBitmap.SetPixel(i, j, newColor);

                    // reset sum
                    tempSum = 0;
                    runningSum = 0;
                }
            return newBitmap;
        }

        //thuật toán phát hiện cảnh của ảnh
        public Bitmap DetectEdge(Bitmap original)
        {
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);
            int xleft;
            int xright;
            int ytop;
            int ybot;
            double gx;
            double gy;
            double tempAngle;
            Color color1, color2;
            double[,] magnitudes = new double[original.Width, original.Height];
            double[,] angles = new double[original.Width, original.Height];
            bool[,] isEdge = new bool[original.Width, original.Height];
            double maxMag = 0;

            // vòng lặp kiểm tra == nó sẽ kiểm tra mọi điểm pixel bằng việc đi qua tất cả các pixel đó
            for (int i = 0; i < original.Width; i++)
                for (int j = 0; j < original.Height; j++)
                {
                    xleft = i - 1;
                    xright = i + 1;
                    ytop = j - 1;
                    ybot = j + 1;

                    // Kiểm tra giới hạn của nó
                    // nếu nó bị out ra khỏi giới hạn thì nó nhận đc giá trị ánh xạ
                    if (xleft < 0)
                        xleft = xright;
                    if (xright > original.Width - 1)
                        xright = xleft;
                    if (ytop < 0)
                        ytop = ybot;
                    if (ybot > original.Height - 1)
                        ybot = ytop;

                    // tính giá trị độ lớn gradient magnitude giá trị X
                    color1 = original.GetPixel(xright, j);
                    color2 = original.GetPixel(xleft, j);
                    gx = (color1.R - color2.R) / 2;

                    // tính giá trị độ lớn gradient magnitude giá trị Y
                    color1 = original.GetPixel(i, ybot);
                    color2 = original.GetPixel(i, ytop);
                    gy = (color1.R - color2.R) / 2;

                    // độ lớn của magnitudes
                    magnitudes[i, j] = Math.Abs(gx) + Math.Abs(gy);
                    if (magnitudes[i, j] > maxMag)
                        maxMag = magnitudes[i, j];

                    // nó sẽ làm bo trọn các góc và lưu các góc đó lại
                    tempAngle = Math.Atan(gy / gx);
                    // r chuyển đổi từ radian sang độ
                    tempAngle = tempAngle * 180 / Math.PI;

                    // θ trong [0°, 22.5°] hoặc [157.6°, 180°] đến giá trị 0°.
                    if ((tempAngle >= 0 && tempAngle < 22.5) || (tempAngle > 157.5 && tempAngle <= 180) || (tempAngle <= 0 && tempAngle > -22.5) || (tempAngle < -157.5 && tempAngle >= -180))
                        tempAngle = 0.0;
                    // θ trong [22.6°, 67.4°] đến 45°.
                    else if ((tempAngle > 22.5 && tempAngle < 67.5) || (tempAngle < -22.5 && tempAngle > -67.5))
                        tempAngle = 45.0;
                    // θ trong [67.5°, 112.5°] đến 90°.
                    else if ((tempAngle > 67.5 && tempAngle < 112.5) || (tempAngle < -67.5 && tempAngle > -112.5))
                        tempAngle = 90.0;
                    // θ trong [112.6°, 157.5°] đến 135°.
                    else if ((tempAngle > 112.5 && tempAngle < 157.5) || (tempAngle < -112.5 && tempAngle > -157.5))
                        tempAngle = 135.0;

                    angles[i, j] = tempAngle;
                }

            // bây giờ phải kiểm tra độ lớn lân cận của mỗi pixel
            for (int i = 0; i < original.Width; i++)
                for (int j = 0; j < original.Height; j++)
                {
                    // nếu góc gradient là 0 °, là cạnh nếu độ lớn gradient của nó lớn hơn độ lớn tại pixel bên trái và bên phải
                    // nếu góc gradient là 90 °, là cạnh nếu độ lớn gradient của nó lớn hơn độ lớn tại pixel  trên  và dưới
                    // nếu góc gradient là 135 °, là cạnh nếu độ lớn gradient của nó lớn hơn độ lớn tại pixel topleft và botright
                    // nếu góc gradient là 45 °, là cạnh nếu độ lớn gradient của nó lớn hơn độ lớn tại pixel  topright và botleft
                    if ((i - 1 < 0 || i + 1 > original.Width - 1 || j - 1 < 0 || j + 1 > original.Height - 1))
                    {
                        isEdge[i, j] = false;
                    }
                    else if (angles[i, j] == 0.0)
                    {

                        if (magnitudes[i, j] > magnitudes[i - 1, j] && magnitudes[i, j] > magnitudes[i + 1, j])
                            isEdge[i, j] = true;
                        else
                            isEdge[i, j] = false;
                    }
                    else if (angles[i, j] == 90.0)
                    {

                        if (magnitudes[i, j] > magnitudes[i, j - 1] && magnitudes[i, j] > magnitudes[i, j + 1])
                            isEdge[i, j] = true;
                        else
                            isEdge[i, j] = false;
                    }
                    else if (angles[i, j] == 135.0)
                    {
                        if (magnitudes[i, j] > magnitudes[i - 1, j - 1] && magnitudes[i, j] > magnitudes[i + 1, j + 1])
                            isEdge[i, j] = true;
                        else
                            isEdge[i, j] = false;
                    }
                    else if (angles[i, j] == 45.0)
                    {
                        if (magnitudes[i, j] > magnitudes[i + 1, j - 1] && magnitudes[i, j] > magnitudes[i - 1, j + 1])
                            isEdge[i, j] = true;
                        else
                            isEdge[i, j] = false;
                    }
                }

            double lowerThreshold = maxMag * 0.10;
            // chạy vong lặp
            for (int i = 0; i < original.Width; i++)
                for (int j = 0; j < original.Height; j++)
                {
                    // nếu mà cạnh của nó
                    if (isEdge[i, j] && magnitudes[i, j] > lowerThreshold)
                    {
                        // kiểm tra pixel theo hướng của cạnh
                        // nếu một trong hai hoặc cả hai đều có
                        // cùng góc với [i, j]
                        // độ lớn> so với ngưỡng thấp hơn
                        // sau đó đánh dấu là cạnh
                        if (angles[i, j] == 0.0)
                        {
                            if (angles[i, j] == angles[i - 1, j] || angles[i, j] == angles[i + 1, j])
                            {
                                if (magnitudes[i - 1, j] > lowerThreshold)
                                    newBitmap.SetPixel(i - 1, j, Color.White);
                                else
                                    newBitmap.SetPixel(i - 1, j, Color.Black);

                                if (magnitudes[i + 1, j] > lowerThreshold)
                                    newBitmap.SetPixel(i + 1, j, Color.White);
                                else
                                    newBitmap.SetPixel(i + 1, j, Color.Black);
                            }
                        }
                        else if (angles[i, j] == 90.0)
                        {
                            if (angles[i, j] == angles[i, j - 1] || angles[i, j] == angles[i, j + 1])
                            {
                                if (magnitudes[i, j - 1] > lowerThreshold)
                                    newBitmap.SetPixel(i, j - 1, Color.White);
                                else
                                    newBitmap.SetPixel(i, j - 1, Color.Black);

                                if (magnitudes[i, j + 1] > lowerThreshold)
                                    newBitmap.SetPixel(i, j + 1, Color.White);
                                else
                                    newBitmap.SetPixel(i, j + 1, Color.Black);
                            }
                        }
                        else if (angles[i, j] == 135.0)
                        {
                            if (angles[i, j] == angles[i - 1, j - 1] || angles[i, j] == angles[i + 1, j + 1])
                            {
                                if (magnitudes[i - 1, j - 1] > lowerThreshold)
                                    newBitmap.SetPixel(i - 1, j - 1, Color.White);
                                else
                                    newBitmap.SetPixel(i - 1, j - 1, Color.Black);

                                if (magnitudes[i + 1, j + 1] > lowerThreshold)
                                    newBitmap.SetPixel(i + 1, j + 1, Color.White);
                                else
                                    newBitmap.SetPixel(i + 1, j + 1, Color.Black);
                            }
                        }
                        else if (angles[i, j] == 45.0)
                        {
                            if (angles[i, j] == angles[i + 1, j - 1] || angles[i, j] == angles[i - 1, j + 1])
                            {
                                if (magnitudes[i + 1, j - 1] > lowerThreshold)
                                    newBitmap.SetPixel(i + 1, j - 1, Color.White);
                                else
                                    newBitmap.SetPixel(i + 1, j - 1, Color.Black);

                                if (magnitudes[i - 1, j + 1] > lowerThreshold)
                                    newBitmap.SetPixel(i - 1, j + 1, Color.White);
                                else
                                    newBitmap.SetPixel(i - 1, j + 1, Color.Black);
                            }
                        }
                    }
                    else
                        newBitmap.SetPixel(i, j, Color.Black);
                }

            return newBitmap;
        }
    }
}
