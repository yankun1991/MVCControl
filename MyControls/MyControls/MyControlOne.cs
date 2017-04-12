using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyControls.MyControls
{
    public static class MyControlOne
    {
        /// <summary>
        /// RadioButton
        /// </summary>
        /// <param name="nametarget">name属性</param>
        /// <param name="idtarget">id属性</param>
        /// <returns></returns>
        public static HtmlString RadioButton(this HtmlHelper helper,string nametarget, string idtarget)
        {
            string str = String.Format("<input type='radio' name='{0}' id='{1}' />", nametarget, idtarget);
            return new HtmlString(str);
        }
    }
}