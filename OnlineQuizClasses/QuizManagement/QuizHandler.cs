﻿using OnlineQuizClasses.UserManagement;
using System.Collections.Generic;
using System.Linq;

namespace OnlineQuizClasses.QuizManagement
{
    public class QuizHandler
    {
        private QuizContext _context = new QuizContext();
        public List<Quiz> GetAllQuizzes()
        {
            using (_context)
            {
                return (from v in _context.Quizzes select v).ToList();
            }
        }

        public Quiz GetQuizId(string name)
        {
            using (_context)
            {
                return (from c in _context.Quizzes where c.QuizTitle == name select c).FirstOrDefault();
            }
        }

        public Quiz GetQuizById(int i)
        {
            using (_context)
            {
                return (from c in _context.Quizzes where c.Id == i select c).FirstOrDefault();
            }
        }

        public List<Question> GetAllQuestion(int id)
        {
            using (_context)
            {
                return (from c in _context.Questions where c.Quiz.Id == id select c).ToList();
            }
        }

        public Quiz GetQuizByUser(User user)
        {
            using (_context)
            {
                return (from c in _context.Quizzes where c.Id == user.Id select c).FirstOrDefault();
            }
        }
    }
}
