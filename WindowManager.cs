using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprite_Editor
{
    public static class WindowManager
    {
        public enum WindowType
        {
            SPKWindow = 0,
            ISPKWindow,
            SSPKWindow,
            ASPKWindow
        }

        public static List<frmSpritePackBrowser> spkWindows;
        public static List<frmIndexSpritePackBrowser> ispkWindows;
        public static List<frmShadowSpritePackBrowser> sspkWindows;
        public static List<frmAlphaSpritePackBrowser> aspkWindows;

        public static string GetTitle(string title, WindowType wtype)
        {
            if(wtype == WindowType.SPKWindow)
            {
                foreach(frmSpritePackBrowser frm in spkWindows)
                {
                    int i = 0;
                    
                    if(title == frm.Text)
                    {
                        i++;
                    }

                    if(i > 0)
                    {
                        return title + "[" + i + "]";
                    }
                    else
                    {
                        return title;
                    }
                }
            }

            if(wtype == WindowType.ISPKWindow)
            {
                foreach (frmIndexSpritePackBrowser frm in ispkWindows)
                {
                    int i = 0;

                    if (title == frm.Text)
                    {
                        i++;
                    }

                    if (i > 0)
                    {
                        return title + "[" + i + "]";
                    }
                    else
                    {
                        return title;
                    }
                }
            }

            if (wtype == WindowType.SSPKWindow)
            {
                foreach (frmShadowSpritePackBrowser frm in sspkWindows)
                {
                    int i = 0;

                    if (title == frm.Text)
                    {
                        i++;
                    }

                    if (i > 0)
                    {
                        return title + "[" + i + "]";
                    }
                    else
                    {
                        return title;
                    }
                }
            }

            if (wtype == WindowType.ASPKWindow)
            {
                foreach (frmAlphaSpritePackBrowser frm in aspkWindows)
                {
                    int i = 0;

                    if (title == frm.Text)
                    {
                        i++;
                    }

                    if (i > 0)
                    {
                        return title + "[" + i + "]";
                    }
                    else
                    {
                        return title;
                    }
                }
            }

            return title;
        }
    }
}
