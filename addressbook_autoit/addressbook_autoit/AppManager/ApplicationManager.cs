using System;
using AutoItX3Lib;


namespace addressbook_autoit
{
	public class ApplicationManager
	{
        public static string WINTITLE = "Free Address Book";
        private AutoItX3 aux;
		private GroupHelper groupHelper;
        private HelperBase helperBase;

        public ApplicationManager()
		{
			aux = new AutoItX3();
			aux.Run(@"c:\book\AddressBook.exe", "", aux.SW_SHOW);
			groupHelper = new GroupHelper(this);
            aux.WinWait(WINTITLE);
			aux.WinActivate(WINTITLE);
			aux.WinWaitActive(WINTITLE);
        }

		public void Stop()
		{
            aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.2c908d510");
        }

		public AutoItX3 Aux
		{
			get
			{
				return aux;
			}
		}

		public GroupHelper Groups
		{
			get
			{
				return groupHelper;
			}
		}
	}

}

