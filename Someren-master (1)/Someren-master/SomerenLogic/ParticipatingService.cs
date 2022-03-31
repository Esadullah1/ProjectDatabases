﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenModel;
using SomerenDAL;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace SomerenLogic
{
    public class ParticipatingService
    {
        ParticipatingDAO participatingDAO;

        public ParticipatingService()
        {
            participatingDAO = new ParticipatingDAO();
        }
        public List<Participating> GetAllParticipaters()
        {
            return participatingDAO.GetAllParticipaters();
            
        }
        public void AddParticipant(int student, string activity)
        {
            participatingDAO.AddParticipant(student, activity);
            
        }
        public void RemoveParticipant(int student, string activity)
        {
            participatingDAO.RemoveParticipant(student, activity);

        }
    }
}