using System;

class UserRagister
{
	static void Main()
	{
		Console.WriteLine(IsBelow14(2023, 1, 14));
		Console.WriteLine(IsBelow14(2008, 12, 30));
	}

	//[!] 만 14세 미만 체크 by (년, 월, 일)
	public static bool IsBelow14(int year, int month, int day)
	{
		// 현재 년월일과 생년월일의 차이 구하기
		var yearDiff = DateTime.Now.Year - year;
		var monthDiff = DateTime.Now.Month - month;
		var dayDiff = DateTime.Now.Day - day;

		//  년도 차이가 14이면 월과 일 차이도 체크
		if (yearDiff == 14)
		{
			// 월 차이가 마이너스면 아직 생일이 지나지 않은 상태
			if (monthDiff < 0)
			{
				Console.Write("14세 미만 입니다 ");
				return true; // 만 14세 미만
			}
			else if (monthDiff == 0)
			{
				if (dayDiff < 0)
				{
					Console.Write("14세 미만 입니다 ");
					return true;
				}
				else
				{
					Console.Write("14세 이상 입니다 ");
					return false; // 만 14세 이상
				}
			}
			else
			{
				Console.Write("14세 이상 입니다 ");
				return false;
			}
		}
		else if (yearDiff < 14)
		{
			Console.Write("14세 미만 입니다 ");
			return true; //아직 14세 미만
		}
		else
		{
			Console.Write("14세 이상 입니다 ");
			return false; // 14세 이상
		}
	}
}
		
