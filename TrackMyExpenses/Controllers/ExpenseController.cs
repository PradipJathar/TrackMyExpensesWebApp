using Microsoft.AspNetCore.Mvc;

namespace TrackMyExpenses.Controllers
{
    public class ExpenseController : Controller
    {
        public IActionResult AddExpense()
        {
            return View();
        }
    }
}
