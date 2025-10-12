using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcadmin10.Models
{
    public class z_sqlQuestions : DapperSql<Questions>
    {
        public z_sqlQuestions()
        {
            OrderByColumn = SessionService.SortColumn;
            OrderByDirection = SessionService.SortDirection;
            DefaultOrderByColumn = "Questions.SortNo,Questions.QuestionText";
            DefaultOrderByDirection = "ASC,ASC";
            DropDownValueColumn = "Questions.SortNo";
            DropDownTextColumn = "Questions.SortNo";
            DropDownOrderColumn = "Questions.SortNo ASC,Questions.QuestionText ASC";
            if (string.IsNullOrEmpty(OrderByColumn)) OrderByColumn = DefaultOrderByColumn;
            if (string.IsNullOrEmpty(OrderByDirection)) OrderByDirection = DefaultOrderByDirection;
        }
    }
}
