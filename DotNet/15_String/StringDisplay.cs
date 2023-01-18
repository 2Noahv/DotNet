//[?] 문자열 묶는 3가지 표현 방법 정리
using System;

class StringDisplay
{
	static void Main()
	{
		var displayName = "";
		var firstName = "길동";
		var lastName = "홍";

		//[1] 더하기(+) 연산자
		displayName = lastName + firstName;
		Console.WriteLine(displayName); // 홍길동

		//[2] string.Format(), string.Format() 메서드 사용
		displayName = string.Format("이름: {0}{1}", lastName, firstName);
		Console.WriteLine(displayName);
		
		//[3] 문자열 보간법 사용
		displayName = $"추천 이름: {lastName}{firstName}";
		Console.WriteLine(displayName);

		// 문자열 비교
		string userName = "RedPlus";
		string userNameInput = "redplus";

		if (userName.ToLower() == userNameInput)
		{
			Console.WriteLine("같습니다.");
		}

		// string.Equals() 메서드 사용 / 비교하는 것
		// StringComparison.InvariantCultureIgnoreCase 대,소문자 구분 X 
		if (string.Equals(userName, userNameInput, StringComparison.InvariantCultureIgnoreCase))
		{
			Console.WriteLine("같습니다.");
		}


		//[?] 문자열 값 비교: 대소문자 비교
		string s1 = "Gilbut";
		string s2 = "gilbut";

		//[1] 문자열의 값의 대소문자를 구분
		if (s1 == s2)
		{
			Console.WriteLine("같다.");
		}
		else
		{
			Console.WriteLine("다르다."); // "다르다." 출력됨
			
			//[2] 문자열의 대소문자를 구분하지 않고 문자만 비교
			if (s1.Equals(s2, StringComparison.OrdinalIgnoreCase))
				{
				Console.WriteLine("같다."); // "같다." 출력됨
				}					
		}
	}
}