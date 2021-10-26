using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Uge34Library.Models;
using Uge34Library.Repo;
using Uge34MVC.Data;

namespace Uge34MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepository<Product> repo;
        private readonly SignInManager<User> user;
        private readonly basketRepoWebsite basketRepo;

        public ProductController(ApplicationDbContext context, SignInManager<User> user)
        {
            repo = new ProductRepo(context);
            basketRepo = new basketRepoWebsite(context);
            this.user = user;
        }

        // GET: Product
        public IActionResult Index()
        {
            return View(repo.GetAll());
        }

        // GET: Product/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = repo.GetByid(id.Value);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,Category,Price,ProductName,Description,Amount")] Product product)
        {
            if (ModelState.IsValid)
            {
                repo.CreateProduct(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }


        public async Task<IActionResult> Buy(int? id)
        {
            if (id == null)
            {
                return NoContent();
            }

            var userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var basket = new Basket();
            basket.UserId = 1;

            var basketContent = repo.GetByid(id.Value);
            if (basketContent == null)
            {
                return NoContent();
            }
            basket.TotalPrice += basketContent.Price;
            basket.BasketAmount += basketContent.Amount;
            var exsist = basketRepo.GetByid(basket.UserId);
            if (exsist == null)
            {
                basketRepo.CreateProduct(basket);
                return Ok();
            }
            else
            {
                basketRepo.Update(basket);
            }
            

            return RedirectToAction(nameof(Index));
        }

        public IActionResult ShowBasket()
        {
            basketRepo.GetByid(1);
            var list = repo.GetAll().Where(x => x.Basket.UserId == 1);

            return View(list);

        }

        // GET: Product/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = repo.GetByid(id.Value);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,Category,Price,ProductName,Description,Amount")] Product product)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    repo.Update(product);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    var pro = repo.GetByid(id);
                    if (product == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        // GET: Product/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = repo.GetByid(id.Value);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = repo.GetByid(id);
            repo.DeleteProduct(product);
            
            return RedirectToAction(nameof(Index));
        }

    }
}
