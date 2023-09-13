
namespace Syslib.Core.Application
{
	internal class CStr_Application
	{

		CStr str = new CStr();
		
		public void Run() 
		{
			this.Init();                // default init
			this.InitWithSize();        // init with string buffer size
			this.InitWithFill();		// init with fillstring
			this.InitWithString();		// init with string

			this.ChangeText();          // set new string value
			this.AppendText();          // append text to string
			this.ReplaceCharacter();	// replace characters

			this.ResizeToBigger();      // increase string buffer
			this.ResizeToSmaller();     // decrease string buffer (truncate)
			this.ClearText();           // clear string
			this.SetSize();             // set string buffer size

			this.AppendCStr();          // concat cstr
			this.BeginWithText();       // string begin with string
			this.EndWithText();         // string ends with string
			this.ContainsChar();        // string contain character

			this.FilterRemove();		// remove characters from string
			this.FilterRemoveLead();    // remove leading characters from string
			this.FilterRemoveTrail();   // remove trailing characters from string
			this.FilterKeep();          // keep characters in string

			this.ToInteger();           // convert string to int32
			this.ToDouble();            // convert string to double

			this.FillString();          // fill string with characters
			this.PadString();           // pad string left or right
			this.Insert();              // insert text
			this.CompareStrings();      // compare strings
			this.Fields();				// field handling

		}


		void Init()
		{
			str = new CStr();
			Console.WriteLine($"Init String =     \"{str}\"  Length = {str.Length()}  String Size = {str.Size()}");
		}

		void InitWithSize()
		{
			str = new CStr(1000);
			Console.WriteLine($"Init String =     \"{str}\"  Length = {str.Length()}  String Size = {str.Size()}");
		}

		void InitWithFill()
		{
			str = new CStr(50,'.');
			Console.WriteLine($"Init String =     \"{str}\"  Length = {str.Length()}  String Size = {str.Size()}");
		}

		void InitWithString() 
		{
			str.Str("Some Text here");
			Console.WriteLine($"Init String =     \"{str}\"  Length = {str.Length()}  String Size = {str.Size()}");
		}


		void ChangeText()
		{
			str.Str("Hello");
			Console.WriteLine($"New String =      \"{str}\"  Length = {str.Length()}  String Size = {str.Size()}");
		}

		void AppendText()
		{
			str.Append(" Corld !");
			Console.WriteLine($"Append String =   \"{str}\"  Length = {str.Length()}  String Size = {str.Size()}");
		}


		void ReplaceCharacter()
		{
			str.Replace('C','W');
			Console.WriteLine($"Replace String =  \"{str}\"  Length = {str.Length()}  String Size = {str.Size()}");
		}



		void ResizeToBigger()
		{
			str.Resize(40);
			Console.WriteLine($"Resize String =   \"{str}\"  Length = {str.Length()}  String Size = {str.Size()}");
		}



		void ResizeToSmaller()
		{
			str.Resize(10);
			Console.WriteLine($"Truncate String = \"{str}\"  Length = {str.Length()}  String Size = {str.Size()}");
		}

		void ClearText()
		{
			str.Clear();
			Console.WriteLine($"Clear String =    \"{str}\"  Length = {str.Length()}  String Size = {str.Size()}");
		}

		void SetSize()
		{
			str.Size(100);
			Console.WriteLine($"Set Size String = \"{str}\"  Length = {str.Length()}  String Size = {str.Size()}");
		}


		void AppendCStr()
		{
			str.Str("Hello").Append(new CStr(" World!"));
			Console.WriteLine($"Append String = \"{str}\"  Length = {str.Length()}  String Size = {str.Size()}");
		}

		void BeginWithText()
		{
			var teststr1 = new CStr("Hello");
			var teststr2 = new CStr("hello");

			Console.WriteLine($"Begin With {teststr1} String = \"{str}\"  {str.BeginWith(teststr1)}");
			Console.WriteLine($"Begin With {teststr2} String = \"{str}\"  {str.BeginWith(teststr2)}");

		}


		void EndWithText()
		{
			var teststr1 = new CStr("World!");
			var teststr2 = new CStr("world!");

			Console.WriteLine($"End With {teststr1} String = \"{str}\"  {str.EndWith(teststr1)}");
			Console.WriteLine($"End With {teststr2} String = \"{str}\"  {str.EndWith(teststr2)}");
		}

		void ContainsChar()
		{
			var testch1 = 'W';
			var testch2 = 'w';

			if (str.Contains(testch1))
				Console.WriteLine($"Contain '{testch1}' String = \"{str}\"  True");
			else
				Console.WriteLine($"Contain '{testch1}' String = \"{str}\"  False");

			if (str.Contains(testch2))
				Console.WriteLine($"Contain '{testch2}' String = \"{str}\"  True");
			else
				Console.WriteLine($"Contain '{testch2}' String = \"{str}\"  False");
		}

		void FilterRemove()
		{
			var removechars = new CStr(" 0123456789");
			str.Str("123 Text 123");

			Console.WriteLine($"Remove characters \"{removechars}\" from \"{str}\" -> \"{str.FilterRemove(removechars)}\"");

		}


		void FilterRemoveLead()
		{
			var removechars = new CStr(" 0123456789");
			str.Str("123 Text 123");

			Console.WriteLine($"Remove Leadcharacters \"{removechars}\" from \"{str}\" -> \"{str.FilterRemoveBegin(removechars)}\"");

		}

		void FilterRemoveTrail()
		{
			var removechars = new CStr(" 0123456789");
			str.Str("123 Text 123");

			Console.WriteLine($"Remove Trailcharacters \"{removechars}\" from \"{str}\" -> \"{str.FilterRemoveEnd(removechars)}\"");

		}

		void FilterKeep()
		{
			var keepchars = new CStr("0123456789");
			str.Str("123 Text 123");

			Console.WriteLine($"Keep characters \"{keepchars}\" in \"{str}\" -> \"{str.FilterKeep(keepchars)}\"");

		}



		void ToInteger()
		{
			str.Str("123");
			Console.WriteLine($"ToInteger \"{str}\" -> {str.ToInt32()}");

			str.Str("123.123");
			Console.WriteLine($"ToInteger \"{str}\" -> {str.ToInt32()}");

			str.Str("123,123");
			Console.WriteLine($"ToInteger \"{str}\" -> {str.ToInt32()}");

			str.Str("123.123,123");
			Console.WriteLine($"ToInteger \"{str}\" -> {str.ToInt32()}");

			str.Str("123,123.123");
			Console.WriteLine($"ToInteger \"{str}\" -> {str.ToInt32()}");

		}

		void ToDouble()
		{
			str.Str("123.123");
			Console.WriteLine($"ToDouble \"{str}\" -> {str.ToDouble()}");

			str.Str("123,123");
			Console.WriteLine($"ToDouble \"{str}\" -> {str.ToDouble()}");


			str.Str("123.123,123");
			Console.WriteLine($"ToDouble \"{str}\" -> {str.ToDouble()}");

			str.Str("123,123.123");
			Console.WriteLine($"ToDouble \"{str}\" -> {str.ToDouble()}");

		}

		void FillString()
		{
			str.Fill(50,'x');
			Console.WriteLine($"Fill String = \"{str}\"  Length = {str.Length()}  String Size = {str.Size()}");
		}


		void PadString()
		{
			str.Str("Hello!").PadLeft(totallength: 20, padcharacter: '-');
			Console.WriteLine($"PadLeft =     \"{str}\"");

			str.Str("Hello!").PadRight(totallength: 20, padcharacter: '-');
			Console.WriteLine($"PadRight =    \"{str}\"");

		}


		void Insert()
		{
			str.Str("some text");
			str.Insert(" INSERT MID ", str.Length() / 2);
			str.Insert(" INSERT END ", str.Length());
			str.Insert(" INSERT BEGINNING  ", 0);

			Console.WriteLine($"Insert =      \"{str}\"");

		}

		void CompareStrings() 
		{
			str.Str("Aaaa");
			var str1 = new CStr("Bbbb");
			var str2 = new CStr("Cccc");

			Console.WriteLine($"Compare  \"{str1}\" with \"{str1}\" =  {str1.Compare(str1)}");
			Console.WriteLine($"Compare  \"{str1}\" with \"{str}\" =  {str1.Compare(str)}");
			Console.WriteLine($"Compare  \"{str1}\" with \"{str2}\" =  {str1.Compare(str2)}");

			Console.WriteLine($"IsEqual  \"{str1}\" and \"{str2}\" =  {str1.IsEqual(str2)}");
			Console.WriteLine($"IsEqual  \"{str1}\" and \"{str1}\" =  {str1.IsEqual(str1)}");

		}


		void Fields()
		{
			str.Str("one,\"two,three\",four");

			Console.WriteLine($"FieldCount  string \"{str}\" contains {str.FieldCount(',', usequote: false)} fields");
			Console.WriteLine($"FieldCount  string \"{str}\" contains {str.FieldCount(',', usequote: true)} fields");

			Console.WriteLine($"First Field in string \"{str}\" is {str.GetField(fieldnumber: 0, fieldseparator: ',', usequote: true)}");

			Console.WriteLine($"Field 1 in string \"{str}\" is {str.GetField(fieldnumber: 1, fieldseparator: ',', usequote: false)}");
			Console.WriteLine($"Field 1 in string \"{str}\" is {str.GetField(fieldnumber: 1, fieldseparator: ',', usequote: true)}");


		}



	}
}
