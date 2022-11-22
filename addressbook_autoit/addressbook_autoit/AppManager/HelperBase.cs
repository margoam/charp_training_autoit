using System;
using AutoItX3Lib;

namespace addressbook_autoit
{
	public class HelperBase
	{
        protected ApplicationManager manager;
        public static string WINTITLE;
        protected AutoItX3 aux;

        public HelperBase()
		{
		}

        public HelperBase(ApplicationManager manager)
        {
            this.manager = manager;
            WINTITLE = ApplicationManager.WINTITLE;
            this.aux = manager.Aux;
        }

        public void WINWAIT(string text)
        {
            aux.WinWait(text);
            aux.WinActivate(text);
            aux.WinWaitActive(text);
        }
    }
}

