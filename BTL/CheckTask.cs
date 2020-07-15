using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL
{
    public class CheckTask
    {
        public static int checkPendingCard()
        {
            int num;
            using (var dbContext = new TODOContext())
            {
                num = dbContext.Cards.Where(c => c.IsDone == false).Count();
            }

            return num;
        }

        public static int checkOutOfDatelineCard()
        {
            int num;
            using (var dbContext = new TODOContext())
            {
                num = dbContext.Cards.Where(c => c.EndTime < DateTime.Now)
                    .Where(c=>c.IsDone== false)
                    .Where(c=>c.Notification==true)
                    .Count();
            }

            return num;
        }
    }
}
