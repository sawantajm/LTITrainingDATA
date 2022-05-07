using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
namespace FinalProject.VModel
{

    public class MarksObtained
    {

        public int count = 0;





        public int MarksObtain(int count)
        {
            QuestionDetail question = new QuestionDetail();

            if (question.SubjectId == 1 && question.LevelId==1)
            {

                for (var QuestionNumber = 0; QuestionNumber <question.QuestionNumber; QuestionNumber++)
                {
                    if (question.Correctanswers[QuestionNumber] == question.Student_response[QuestionNumber])
                    {
                        count = count + 1;
                    }
                    else
                    {
                        count = count;
                    }
                    

                }
                
            }
            return count;
        }

    }
}
