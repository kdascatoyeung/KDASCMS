﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.ComponentModel;

namespace KDTHK_SYS_MAN_CONSOLE.utils
{
    public class ImpersonatedUser : IDisposable
    {
        IntPtr userHandle;
        WindowsImpersonationContext impersonationContext;

        public ImpersonatedUser(string user, string domain, string password)
        {
            userHandle = IntPtr.Zero;

            bool loggedOn = LogonUser(user, domain, password, LoginType.Interactive, LogonProvider.Default, out userHandle);

            if (!loggedOn)
                throw new Win32Exception(Marshal.GetLastWin32Error());

            impersonationContext = WindowsIdentity.Impersonate(userHandle);
        }

        public void Dispose()
        {
            if(userHandle!=IntPtr.Zero)
            {
                CloseHandle(userHandle);
                userHandle = IntPtr.Zero;
                impersonationContext.Undo();
            }
        }

        [DllImport("advapi32.dll", SetLastError = true)]
        static extern bool LogonUser(
            string lpszUsername,
            string lpszDomain,
            string lpszPassword,
            LoginType dwLogonType,
            LogonProvider dwLogonProvider,
            out IntPtr phToken
        );

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool CloseHandle(IntPtr hHandle);

        enum LoginType : int
        {
            Interactive = 2,
            Network = 3,
            Batch = 4,
            Service = 5,
            NetworkCleartext = 8,
            NewCredentials = 9,
        }

        enum LogonProvider:int
        {
            Default = 0,
        }
    }
}
