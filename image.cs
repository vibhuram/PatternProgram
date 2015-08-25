using System;
using System.Drawing;
	public class ImagePattern{  
		public static string check (string path, string org,int cor){ //create new method to check two images
			Bitmap image1,orgimg; 
			image1 = new Bitmap (path,true);
			orgimg = new Bitmap (org,true);
			string cnt = ""; 
			if (image1.Height!=orgimg.Height || image1.Width!=orgimg.Width){  //check if both images have same height and width
				cnt = "height/width mismatch";
			} 
			else {
				switch (cor){
					case 1: for (int x=0; x< image1.Height/2;x++){  //switch case for corner 1 (top left)
								for (int y=0;y<image1.Width/2 && cnt == "";y++){
									Color myColor = image1.GetPixel(x,y);
									Color orgColor = orgimg.GetPixel(x,y);
									System.ComponentModel.TypeConverter converter = System.ComponentModel.TypeDescriptor.GetConverter(myColor);
									System.ComponentModel.TypeConverter orgconverter = System.ComponentModel.TypeDescriptor.GetConverter(orgColor);
   									if (converter.ConvertToString(image1.GetPixel(x,y)) != orgconverter.ConvertToString(orgimg.GetPixel(x,y))){
										cnt = "top left, ";
									}
								}
							}
							break;
					case 2: for (int x=image1.Height/2; x< image1.Height;x++){  //switch case for corner 2 (top right)
								for (int y=0;y<image1.Width/2 && cnt == "";y++){
									Color myColor = image1.GetPixel(x,y);
									Color orgColor = orgimg.GetPixel(x,y);
									System.ComponentModel.TypeConverter converter = System.ComponentModel.TypeDescriptor.GetConverter(myColor);
									System.ComponentModel.TypeConverter orgconverter = System.ComponentModel.TypeDescriptor.GetConverter(orgColor);
   									if (converter.ConvertToString(image1.GetPixel(x,y)) != orgconverter.ConvertToString(orgimg.GetPixel(x,y))){
										cnt = "top right, ";
									}
								}
							}
							break;
					case 3: for (int x=image1.Height/2; x< image1.Height;x++){  //switch case for corner 3 (bottom right)
								for (int y=image1.Width/2;y<image1.Width && cnt == "";y++){
									Color myColor = image1.GetPixel(x,y);
									Color orgColor = orgimg.GetPixel(x,y);
									System.ComponentModel.TypeConverter converter = System.ComponentModel.TypeDescriptor.GetConverter(myColor);
									System.ComponentModel.TypeConverter orgconverter = System.ComponentModel.TypeDescriptor.GetConverter(orgColor);
   									if (converter.ConvertToString(image1.GetPixel(x,y)) != orgconverter.ConvertToString(orgimg.GetPixel(x,y))){
										cnt = "bottom right, ";
									}
								}
							}
							break;
					case 4: for (int x=image1.Height; x< image1.Height/2;x++){  //switch case for corner 4 (bottom left)
								for (int y=image1.Width/2;y<image1.Width && cnt == "";y++){
									Color myColor = image1.GetPixel(x,y);
									Color orgColor = orgimg.GetPixel(x,y);
									System.ComponentModel.TypeConverter converter = System.ComponentModel.TypeDescriptor.GetConverter(myColor);
									System.ComponentModel.TypeConverter orgconverter = System.ComponentModel.TypeDescriptor.GetConverter(orgColor);
   									if (converter.ConvertToString(image1.GetPixel(x,y)) != orgconverter.ConvertToString(orgimg.GetPixel(x,y))){
										cnt = "bottom left, ";
									}
								}
							}
							break;		
				}
			} 
				return cnt;
		}
		public static void EnterPath(string FilePath, string OrgFilePath){ //create new method to take file paths
			string mis = "mismatch: ";
			mis = mis+ check (FilePath,OrgFilePath,1);
			mis = mis+ check (FilePath,OrgFilePath,2);
			mis = mis+ check (FilePath,OrgFilePath,3);
			mis = mis+ check (FilePath,OrgFilePath,4);
			System.Console.WriteLine(mis);
		}
		
		public static void Main(string[] args){  //main method
			 EnterPath (@"C:\Users\Srivibhu\Desktop\csharp\testimage.bmp",@"C:\Users\Srivibhu\Desktop\csharp\orgimage.bmp");
			}
		}