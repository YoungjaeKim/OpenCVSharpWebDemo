using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OpenCvSharp;

namespace OpenCvSharpWeb.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Canny(HttpPostedFileBase imageData)
		{
			// 入力画像からIplImageを読み込み
			using (var image = IplImage.FromStream(imageData.InputStream, LoadMode.Color))
			{
				// グレースケール化・Cannyエッジ検出
				using (var grayImage = new IplImage(image.Size, BitDepth.U8, 1))
				using (var cannyImage = new IplImage(image.Size, BitDepth.U8, 1))
				{
					Cv.CvtColor(image, grayImage, ColorConversion.BgrToGray);
					Cv.Canny(grayImage, cannyImage, 60, 180);

					// Canny画像をPNGエンコードでバイト配列に変換し、さらにBase64エンコードする
					byte[] cannyBytes = cannyImage.ToBytes(".png");
					string base64 = Convert.ToBase64String(cannyBytes);
					// ビュー変数に設定
					ViewBag.Base64Image = base64;
				}
			}
			return View();
		}
	}
}