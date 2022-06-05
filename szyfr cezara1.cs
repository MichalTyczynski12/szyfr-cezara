using System;
using System.Text;

public class Program
{
	public static void Main()
	{
		string tekst = "YFELXIKFGXG";
		int klucz = 20;
		int n = tekst.Length;
		string rozwiazanie = "";
		byte[] bytes = Encoding.ASCII.GetBytes(tekst);

		if (klucz > -26 && klucz < 26)
		{
			for (int i = 0; i < n; i++)
			{
				if (bytes[i] + klucz > 90) // > Z
				{
					if (klucz < 0)
					{
						bytes[i] -= Convert.ToByte(Math.Abs((klucz)));
					}
					else
					{
						bytes[i] += Convert.ToByte((klucz));
					}

					bytes[i] -= Convert.ToByte(26);
				}
				else if (bytes[i] + klucz < 65) // < A
				{
					bytes[i] += Convert.ToByte(klucz + 26);
				}
				else
				{
					if (klucz < 0)
					{
						bytes[i] -= Convert.ToByte(Math.Abs((klucz)));
					}
                    else
                    {
						bytes[i] += Convert.ToByte((klucz));
					}
				}
			}
			rozwiazanie = Encoding.ASCII.GetString(bytes);
		}

		Console.WriteLine(rozwiazanie);
	}
}