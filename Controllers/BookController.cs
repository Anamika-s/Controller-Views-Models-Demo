using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationMVCCore.Models;

namespace WebApplicationMVCCore.Controllers
{
    public class BookController : Controller
    {
        static List<Book> listBooks = null;
        private void InitializeBooks()
        {
            if(listBooks==null)
            {
                listBooks = new List<Book>()
                 {
                     new Book() {Id=100, BookName="Let us C", AuthorName="Authao1" , PublishDate=Convert.ToDateTime("12/12/1999") , Price=220},

                     new Book() {Id=101, BookName="Let us learn C++", AuthorName="Autho2" , PublishDate=Convert.ToDateTime("11/09/1999") , Price=770},

                     new Book() {Id=102, BookName="Let us learn C#", AuthorName="Author3" , PublishDate=Convert.ToDateTime("12/12/1999") , Price=220},

                     new Book() {Id=103, BookName="Let us learn Java", AuthorName="Author4" , PublishDate=Convert.ToDateTime("12/12/1999") , Price=220},

                     new Book() {Id=104, BookName="Let us learn MERN", AuthorName="Author5" , PublishDate=Convert.ToDateTime("12/12/1999") , Price=220}
                 };
            }

        }
        public BookController()
        {
            InitializeBooks();
        }
        public IActionResult Index()
        {

            return View(listBooks);
        }

        public IActionResult Details(int id)
        {
            var book = listBooks.FirstOrDefault(x => x.Id == id);
            return View(book);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            listBooks.Add(book);
            return RedirectToAction("Index");
        }

        public IActionResult Edit (int id)
        {
            var book = listBooks.FirstOrDefault(x => x.Id == id);
            if (book != null)
                return View(book);
            else
            {
                ViewBag.msg = "There is no book with this ID";
                return View();
            }
        }
        [HttpPost]
        public IActionResult Edit(int id, Book book)
        {
            var objBook = listBooks.FirstOrDefault(x => x.Id == id);
            if (objBook != null)
                for(int i=0;i<listBooks.Count;i++)
                {
                     if(listBooks[i].Id == book.Id)
                    {
                        listBooks[i].BookName = book.BookName;
                        listBooks[i].AuthorName = book.AuthorName;
                        listBooks[i].PublishDate = book.PublishDate;
                        listBooks[i].Price = book.Price;
                        break;
                    }
                   
                }
            return RedirectToAction("Index");
                   
        }


        public IActionResult Delete(int id)
        {
            var book = listBooks.FirstOrDefault(x => x.Id == id);
            if (book != null)
                return View(book);
            else
            {
                ViewBag.msg = "There is no book with this ID";
                return View();
            }
        }

        [HttpPost]
        public IActionResult Delete(int id, Book book)
        {
            var objbook = listBooks.FirstOrDefault(x => x.Id == id);
            if (objbook != null)
            listBooks.Remove(objbook);
            return RedirectToAction("Index");
        }
        }

    }

