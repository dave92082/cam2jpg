using System;
using System.IO;
using System.Collections.Generic;
namespace cam2jpg
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			if (args.Length < 1) {
				Console.WriteLine ("Missing File Argument");
				return;
			}

			Console.WriteLine ("Reading File: "+ args [0]) ;
			bool headerFound = false;

			byte[] buffer = File.ReadAllBytes (args [0]);
			List<Byte> image = new List<Byte> ();

			for (int i = 0; i < buffer.Length; i++) {
				if (buffer [i] == 255 && buffer [i + 1] == 216) {
					headerFound = true;
				}
				if (headerFound) {
					image.Add (buffer [i]);
				}
			}
			File.WriteAllBytes (args [0] + ".jpg", image.ToArray ());
		}
	}
}
