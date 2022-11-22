using System;
using System.Runtime.Intrinsics.X86;

namespace addressbook_autoit
{
	public class GroupHelper : HelperBase
	{
        public static string GROUPWINTITLE = "Group editor";
        public GroupHelper(ApplicationManager manager) : base(manager)
		{

		}

        public void Add(GroupData newGroup)
        {
            OpenGroupsDialogue();
            aux.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.1114f8110");
            aux.Send(newGroup.Name);
            aux.Send("{ENTER}");
            CloseGroupsDialogue();
        }

        public List<GroupData> GetGroupList()
        {
            List<GroupData> list = new List<GroupData>();
            OpenGroupsDialogue();
            string count = aux.ControlTreeView
                (GROUPWINTITLE, "", "WindowsForms10.SysTreeView32.app.0.1114f81", "GetItemCount", "#0", "");
            for (int i = 0; i < int.Parse(count); i++)
            {
                string item = aux.ControlTreeView
                    (GROUPWINTITLE, "", "WindowsForms10.SysTreeView32.app.0.1114f81", "GetText", "#0|#" + i, "");
                list.Add(new GroupData()
                {
                    Name = item
                });
            }
            CloseGroupsDialogue();

            return list;
        }

        public List<GroupData> IfGroupNotExists(int index, GroupData newGroup)
        {
            while (GetGroupList().Count < index + 1)
            {
                Add(newGroup);
            }

            return GetGroupList();
        }

        internal void Remove(int v)
        {
            OpenGroupsDialogue();
            aux.ControlTreeView
                (GROUPWINTITLE, "", "WindowsForms10.SysTreeView32.app.0.1114f81", "Select", "#0|#" + 0, "");
            aux.ControlClick(GROUPWINTITLE, "", "WindowsForms10.BUTTON.app.0.1114f81");
            aux.WinWait("Delete group");
            aux.ControlClick("Delete group", "", "WindowsForms10.BUTTON.app.0.1114f81");
            aux.ControlClick("Delete group", "", "WindowsForms10.BUTTON.app.0.1114f8110");
            CloseGroupsDialogue();
        }

        private void CloseGroupsDialogue()
        {
            aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.1114f8114");
        }

        private void OpenGroupsDialogue()
        {
            aux.ControlClick(WINTITLE, "", "WindowsForms10.BUTTON.app.0.1114f8112");
            aux.WinWait(GROUPWINTITLE);
        }
    }


}

