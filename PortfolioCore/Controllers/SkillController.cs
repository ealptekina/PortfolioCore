﻿using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class SkillController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult SkillList()
        {
            var values = context.Skills.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSkill(Skill sk)
        {
            context.Skills.Add(sk);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        public IActionResult DeleteSkill(int id)
        {
            var values = context.Skills.Find(id);
            context.Skills.Remove(values);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        [HttpGet]
        public IActionResult UpdateSkill(int id)
        {
            var values = context.Skills.Find(id);
            return View(values);
        }
        

        [HttpPost]
        public IActionResult UpdateSkill(Skill sk)
        {
            context.Skills.Update(sk);
            context.SaveChanges();
            return RedirectToAction("SkillList");
        }
    }
}
