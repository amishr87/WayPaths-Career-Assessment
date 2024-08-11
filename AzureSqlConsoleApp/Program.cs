using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

class Program
{
    static void Main()
    {
        // Connection string to your Azure SQL Database
        string connectionString = "Server=tcp:careerassessmentserver.database.windows.net,1433;Initial Catalog=careerassessment;Persist Security Info=False;User ID=careeradmin;Password=career@123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        // Query to select the last row from your table based on submission date
        string query = "SELECT TOP 1 * FROM dbo.Assessment ORDER BY submissionDate DESC";

        try
        {
            // Establishing connection to the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Creating SQL command
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Executing the command and reading the data
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Checking if there is data available
                        if (reader.HasRows)
                        {
                            // Reading the last row (which is the first row selected in this case)
                            reader.Read();

                            // Storing each column value in separate variables
                            string uid = reader["UserId"].ToString();
                            string userName = reader["UserName"].ToString();
                            string email = reader["Email"].ToString();
                            string submissionDate = reader["SubmissionDate"].ToString();
                            string q1 = reader["q1"].ToString();
                            string q2 = reader["q2"].ToString();
                            string q3 = reader["q3"].ToString();
                            string q4 = reader["q4"].ToString();
                            string q5 = reader["q5"].ToString();
                            string q6 = reader["q6"].ToString();
                            string q7 = reader["q7"].ToString();
                            string q8 = reader["q8"].ToString();
                            string q9 = reader["q9"].ToString();
                            string q10 = reader["q10"].ToString();
                            string q11 = reader["q11"].ToString();
                            string q12 = reader["q12"].ToString();
                            string q13 = reader["q13"].ToString();
                            string q14 = reader["q14"].ToString();
                            string q15 = reader["q15"].ToString();
                            string q16 = reader["q16"].ToString();
                            string q17 = reader["q17"].ToString();
                            string q18 = reader["q18"].ToString();

                            // Close the reader before executing the update command
                            // Printing the values
                            reader.Close();

                            // Printing the values
                            Console.WriteLine($"UID: {uid}");
                            Console.WriteLine($"User Name: {userName}");
                            Console.WriteLine($"Email: {email}");
                            Console.WriteLine($"Submission Date: {submissionDate}");
                            Console.WriteLine($"Q1: {q1}");
                            Console.WriteLine($"Q2: {q2}");
                            Console.WriteLine($"Q3: {q3}");
                            Console.WriteLine($"Q4: {q4}");
                            Console.WriteLine($"Q5: {q5}");
                            Console.WriteLine($"Q6: {q6}");
                            Console.WriteLine($"Q7: {q7}");
                            Console.WriteLine($"Q8: {q8}");
                            Console.WriteLine($"Q9: {q9}");
                            Console.WriteLine($"Q10: {q10}");
                            Console.WriteLine($"Q11: {q11}");
                            Console.WriteLine($"Q12: {q12}");
                            Console.WriteLine($"Q13: {q13}");
                            Console.WriteLine($"Q14: {q14}");
                            Console.WriteLine($"Q15: {q15}");
                            Console.WriteLine($"Q16: {q16}");
                            Console.WriteLine($"Q17: {q17}");
                            Console.WriteLine($"Q18: {q18}");

                            Console.WriteLine("----------------------------------------");

                            // Assuming Scores class is where you process these values
                            Scores scores = new Scores();

                            //calculate trait scores
                            quesOne(q1, scores);
                            quesTwo(q2, scores);
                            quesThree(q3, scores);
                            quesFour(q4, scores);
                            quesFive(q5, scores);
                            quesSix(q6, scores);
                            quesSeven(q7, scores);
                            quesEight(q8, scores);
                            quesNine(q9, scores);
                            quesTen(q10, scores);
                            quesEleven(q11, scores);
                            quesTwelve(q12, scores);
                            quesThirteen(q13, scores);
                            quesFourteen(q14, scores);
                            quesFifteen(q15, scores);
                            quesSixteen(q16, scores);
                            quesSeventeen(q17, scores);
                            quesEighteen(q18, scores);

                            // Print all trait scores
                            Console.WriteLine("-------TRAIT SCORES-------");
                            Console.WriteLine("Accuracy: " + scores.Accuracy);
                            Console.WriteLine("Adaptability: " + scores.Adaptability);
                            Console.WriteLine("Alignment: " + scores.Alignment);
                            Console.WriteLine("Analytical Skills: " + scores.AnalyticalSkills);
                            Console.WriteLine("Attention to Detail: " + scores.AttentionToDetail);
                            Console.WriteLine("Balance: " + scores.Balance);
                            Console.WriteLine("Collaboration: " + scores.Collaboration);
                            Console.WriteLine("Communication: " + scores.Communication);
                            Console.WriteLine("Critical Thinking: " + scores.CriticalThinking);
                            Console.WriteLine("Creativity: " + scores.Creativity);
                            Console.WriteLine("Decision Making: " + scores.DecisionMaking);
                            Console.WriteLine("Empathy: " + scores.Empathy);
                            Console.WriteLine("Flexibility: " + scores.Flexibility);
                            Console.WriteLine("Integrity: " + scores.Integrity);
                            Console.WriteLine("Leadership: " + scores.Leadership);
                            Console.WriteLine("Organizational Skills: " + scores.OrganizationalSkills);
                            Console.WriteLine("Persistence: " + scores.Persistence);
                            Console.WriteLine("Practical: " + scores.Practical);
                            Console.WriteLine("Precision: " + scores.Precision);
                            Console.WriteLine("Problem Solving: " + scores.ProblemSolving);
                            Console.WriteLine("Rational: " + scores.Rational);
                            Console.WriteLine("Relationship Building: " + scores.RelationshipBuilding);
                            Console.WriteLine("Resilience: " + scores.Resilience);
                            Console.WriteLine("Self Reliance: " + scores.SelfReliance);
                            Console.WriteLine("Social: " + scores.Social);
                            Console.WriteLine("Strategic Thinking: " + scores.StrategicThinking);
                            Console.WriteLine("Persuasive: " + scores.Persuasive);
                            Console.WriteLine("Vision: " + scores.Vision);

                            Console.WriteLine("----------------------------------------");

                            //calculate skill scores
                            double analyticalSkills = scores.CriticalThinking + scores.Rational + scores.Precision + scores.Accuracy;
                            double communicationSkills = scores.Communication + scores.Persuasive + scores.Flexibility + scores.Social;
                            double leadershipSkills = scores.Vision + scores.DecisionMaking + scores.Leadership + scores.Integrity;
                            double organizationalSkills = scores.AttentionToDetail + scores.SelfReliance + scores.StrategicThinking + scores.Flexibility;
                            double adaptabilitySkills = scores.Resilience + scores.Flexibility + scores.Rational + scores.Persistence;
                            double creativityAndInnovation = scores.Creativity + scores.CriticalThinking + scores.Vision + scores.StrategicThinking;
                            double interpersonalSkills = scores.Empathy + scores.RelationshipBuilding + scores.Persuasive + scores.Social;
                            double problemSolvingSkills = scores.Persistence + scores.Rational + scores.DecisionMaking + scores.CriticalThinking;
                            double technicalSkills = scores.Precision + scores.Accuracy + scores.CriticalThinking + scores.AttentionToDetail;
                            double emotionalIntelligence = scores.Empathy + scores.Flexibility + scores.Social + scores.Resilience;
                            double projectManagementSkills = scores.StrategicThinking + scores.Leadership + scores.Collaboration + scores.DecisionMaking;
                            double personalQualities = scores.Integrity + scores.SelfReliance + scores.Persistence + scores.Social;

                            // Create a dictionary to hold skill names and their corresponding scores
                            var skillScores = new Dictionary<string, double>
                            {
                                { "Analytical Skills", scores.CriticalThinking + scores.Rational + scores.Precision + scores.Accuracy },
                                { "Communication Skills", scores.Communication + scores.Persuasive + scores.Flexibility + scores.Social },
                                { "Leadership Skills", scores.Vision + scores.DecisionMaking + scores.Leadership + scores.Integrity },
                                { "Organizational Skills", scores.AttentionToDetail + scores.SelfReliance + scores.StrategicThinking + scores.Flexibility },
                                { "Adaptability Skills", scores.Resilience + scores.Flexibility + scores.Rational + scores.Persistence },
                                { "Creativity and Innovation", scores.Creativity + scores.CriticalThinking + scores.Vision + scores.StrategicThinking },
                                { "Interpersonal Skills", scores.Empathy + scores.RelationshipBuilding + scores.Persuasive + scores.Social },
                                { "Problem Solving Skills", scores.Persistence + scores.Rational + scores.DecisionMaking + scores.CriticalThinking },
                                { "Technical Skills", scores.Precision + scores.Accuracy + scores.CriticalThinking + scores.AttentionToDetail },
                                { "Emotional Intelligence", scores.Empathy + scores.Flexibility + scores.Social + scores.Resilience },
                                { "Project Management Skills", scores.StrategicThinking + scores.Leadership + scores.Collaboration + scores.DecisionMaking },
                                { "Personal Qualities", scores.Integrity + scores.SelfReliance + scores.Persistence + scores.Social }
                            };

                            // Sort the dictionary by score in descending order and get top 3 entries
                            var topSkills = skillScores.OrderByDescending(x => x.Value).Take(3).ToList();

                            // Extract skill names for top 3 values
                            string S1 = topSkills.Count > 0 ? topSkills[0].Key : "N/A";
                            string S2 = topSkills.Count > 1 ? topSkills[1].Key : "N/A";
                            string S3 = topSkills.Count > 2 ? topSkills[2].Key : "N/A";

                            
                            


                            
                            // Print all calculated skill scores
                            Console.WriteLine("-------SKILL SCORES-------");
                            Console.WriteLine("Analytical Skills: " + analyticalSkills);
                            Console.WriteLine("Communication Skills: " + communicationSkills);
                            Console.WriteLine("Leadership Skills: " + leadershipSkills);
                            Console.WriteLine("Organizational Skills: " + organizationalSkills);
                            Console.WriteLine("Adaptability Skills: " + adaptabilitySkills);
                            Console.WriteLine("Creativity and Innovation: " + creativityAndInnovation);
                            Console.WriteLine("Interpersonal Skills: " + interpersonalSkills);
                            Console.WriteLine("Problem Solving Skills: " + problemSolvingSkills);
                            Console.WriteLine("Technical Skills: " + technicalSkills);
                            Console.WriteLine("Emotional Intelligence: " + emotionalIntelligence);
                            Console.WriteLine("Project Management Skills: " + projectManagementSkills);
                            Console.WriteLine("Personal Qualities: " + personalQualities);

                            // Create a list of trait scores and their names
                            var traits = new List<(string Name, double Score)>
                            {
                                ("Accuracy", scores.Accuracy),
                                ("Adaptability", scores.Adaptability),
                                ("Alignment", scores.Alignment),
                                ("Analytical Skills", scores.AnalyticalSkills),
                                ("Attention to Detail", scores.AttentionToDetail),
                                ("Balance", scores.Balance),
                                ("Collaboration", scores.Collaboration),
                                ("Communication", scores.Communication),
                                ("Critical Thinking", scores.CriticalThinking),
                                ("Creativity", scores.Creativity),
                                ("Decision Making", scores.DecisionMaking),
                                ("Empathy", scores.Empathy),
                                ("Flexibility", scores.Flexibility),
                                ("Integrity", scores.Integrity),
                                ("Leadership", scores.Leadership),
                                ("Organizational Skills", scores.OrganizationalSkills),
                                ("Persistence", scores.Persistence),
                                ("Practical", scores.Practical),
                                ("Precision", scores.Precision),
                                ("Problem Solving", scores.ProblemSolving),
                                ("Rational", scores.Rational),
                                ("Relationship Building", scores.RelationshipBuilding),
                                ("Resilience", scores.Resilience),
                                ("Self Reliance", scores.SelfReliance),
                                ("Social", scores.Social),
                                ("Strategic Thinking", scores.StrategicThinking),
                                ("Persuasive", scores.Persuasive),
                                ("Vision", scores.Vision)
                            };

                            // Sort traits by score in descending order
                            var topTraits = traits.OrderByDescending(t => t.Score).Take(3).ToList();

                            // Print the top 3 traits
                            string T1 = topTraits[0].Name;
                            string T2 = topTraits[1].Name;
                            string T3 = topTraits[2].Name;

                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("-------TOP 3 TRAITS-------");
                            Console.WriteLine("Top Trait 1: " + T1);
                            Console.WriteLine("Top Trait 2: " + T2);
                            Console.WriteLine("Top Trait 3: " + T3);

                            // Print the top 3 values
                            Console.WriteLine("----------------------------------------");
                            Console.WriteLine("-------TOP 3 SKILLS-------");
                            Console.WriteLine("Top 3 values:");
                            Console.WriteLine("S1: " + S1);
                            Console.WriteLine("S2: " + S2);
                            Console.WriteLine("S3: " + S3);

                            // Define the SQL query to fetch the UserId of the last row
                            string getLastRowQuery = "SELECT TOP 1 UserId FROM dbo.Assessment ORDER BY UserId DESC";

                            // Define the SQL query to update the last row with new values
                            string updateQuery = "UPDATE dbo.Assessment SET T1 = @T1, T2 = @T2, T3 = @T3, S1 = @S1, S2 = @S2, S3 = @S3 WHERE UserId = @UserId";

                            using (SqlConnection mainConnection = new SqlConnection(connectionString))
                            {
                                mainConnection.Open();
                                
                                // Get the UserId of the last row
                                int lastUserId = -1;
                                using (SqlCommand getLastRowCommand = new SqlCommand(getLastRowQuery, connection))
                                {
                                    object result = getLastRowCommand.ExecuteScalar();
                                    if (result != null)
                                    {
                                        lastUserId = Convert.ToInt32(result);
                                    }
                                }

                                if (lastUserId != -1)
                                {
                                    // Update the last row with the new values using the last UserId
                                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                                    {
                                        updateCommand.Parameters.AddWithValue("@T1", T1);
                                        updateCommand.Parameters.AddWithValue("@T2", T2);
                                        updateCommand.Parameters.AddWithValue("@T3", T3);
                                        updateCommand.Parameters.AddWithValue("@S1", S1);
                                        updateCommand.Parameters.AddWithValue("@S2", S2);
                                        updateCommand.Parameters.AddWithValue("@S3", S3);
                                        updateCommand.Parameters.AddWithValue("@UserId", lastUserId);

                                        // Execute the update command
                                        updateCommand.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    // Handle the case where no rows are found (if necessary)
                                }
                            }

                            
                        }
                        else
                        {
                            Console.WriteLine("No data found.");
                        }
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void quesOne(string q1, Scores scores)
    {
        string q1Final = q1.Trim().ToLower();
        switch (q1Final)
        {
            case "getting recognized and rewarded for my efforts":
                scores.Leadership += 1;
                break;
            case "making a positive impact on my community or society":
                scores.Empathy += 1;
                break;
            case "learning new things and growing as a person":
                scores.Resilience += 1;
                break;
            case "working together with others to achieve common goals":
                scores.RelationshipBuilding += 1;
                break;
        }
    }

    static void quesTwo(string q2, Scores scores)
    {
        string q2Final = q2.Trim().ToLower();
        switch (q2Final)
        {
            case "earning a high salary and having great benefits":
                scores.Rational += 1;
                break;
            case "finding personal fulfillment and a sense of purpose in my work":
                scores.Integrity += 1;
                break;
            case "being in a position of influence and leadership":
                scores.Leadership += 1;
                break;
            case "maintaining a good balance between work and personal life":
                scores.Flexibility += 1;
                break;
        }
    }

    static void quesThree(string q3, Scores scores)
    {
        string q3Final = q3.Trim().ToLower();
        switch (q3Final)
        {
            case "i feel uncomfortable and prefer working with people similar to me":
                scores.Adaptability += 0;
                break;
            case "i can manage but it's not my preference":
                scores.Adaptability += 0.25;
                break;
            case "i look forward to learning from different perspectives":
                scores.Adaptability += 0.5;
                break;
            case "i enjoy the diversity and think it enhances our work":
                scores.Adaptability += 0.75;
                break;
            case "i thrive in diverse environments and actively seek such opportunities":
                scores.Adaptability += 1;
                break;
        }
    }


    static void quesFour(string q4, Scores scores)
    {
        string q4Final = q4.Trim().ToLower();
        switch (q4Final)
        {
            case "the project has clear instructions and guidelines, and everyone knows their role":
                scores.StrategicThinking += 1;
                break;
            case "the project allows for creativity and trying out new ideas":
                scores.Creativity += 1;
                break;
            case "the project is fast-paced and requires quick decisions and adaptability":
                scores.Adaptability += 1;
                break;
            case "the project involves a lot of teamwork and collaboration":
                scores.RelationshipBuilding += 1;
                break;
            case "the project allows you to work independently on your part":
                scores.SelfReliance += 1;
                break;
        }
    }

    static void quesFive(string q5, Scores scores)
    {
        string q5Final = q5.Trim().ToLower();
        switch (q5Final)
        {
            case "improving how people experience services or products":
                scores.Communication += 1;
                break;
            case "creating new and innovative solutions":
                scores.Creativity += 1;
                break;
            case "tackling environmental and sustainability issues":
                scores.Integrity += 1;
                break;
            case "addressing social justice and inclusion":
                scores.Empathy += 1;
                break;
        }
    }

    static void quesSix(string q6, Scores scores)
    {
        string q6Final = q6.Trim().ToLower();
        switch (q6Final)
        {
            case "solving puzzles or complex problems":
                scores.CriticalThinking += 1;
                break;
            case "talking and presenting ideas to others":
                scores.Communication += 1;
                break;
            case "organizing events or plans":
                scores.AttentionToDetail += 1;
                break;
            case "working on technical projects or experiments":
                scores.Precision += 1;
                break;
        }
    }

    static void quesSeven(string q7, Scores scores)
    {
        string q7Final = q7.Trim().ToLower();
        switch (q7Final)
        {
            case "i prefer learning through structured courses and training":
                scores.StrategicThinking += 1;
                break;
            case "i enjoy exploring and experimenting to learn new things":
                scores.Creativity += 1;
                break;
            case "i learn best by collaborating and discussing with others":
                scores.Communication += 1;
                break;
            case "i rely on self-study and independent research":
                scores.SelfReliance += 1;
                break;
        }
    }

    static void quesEight(string q8, Scores scores)
    {
        string q8Final = q8.Trim().ToLower();
        switch (q8Final)
        {
            case "i get defensive and find it hard to accept":
                // No points for Low Resilience
                break;
            case "i consider it but often feel discouraged":
                scores.Resilience += 0.5;
                break;
            case "i appreciate it and use it to improve":
                scores.Resilience += 0.75;
                break;
            case "i actively seek feedback and view it as a growth opportunity":
                scores.Resilience += 1;
                break;
        }
    }
    static void quesNine(string q9, Scores scores)
    {
        string q9Final = q9.Trim().ToLower();
        switch (q9Final)
        {
            case "persistent in achieving goals":
                scores.Persistence += 1;
                break;
            case "always accurate and detail-oriented":
                scores.Accuracy += 1;
                break;
            case "visionary and forward-thinking":
                scores.Vision += 1;
                break;
            case "flexible and adaptable to new situations":
                scores.Flexibility += 1;
                break;
        }
    }

    static void quesTen(string q10, Scores scores)
    {
        string q10Final = q10.Trim().ToLower();
        switch (q10Final)
        {
            case "i create detailed plans and follow them closely":
                scores.AttentionToDetail += 1;
                break;
            case "i prioritize tasks based on urgency and importance":
                scores.DecisionMaking += 1;
                break;
            case "i adapt my plans as needed and stay flexible":
                scores.Flexibility += 1;
                break;
            case "i rely on collaboration and delegation":
                scores.Collaboration += 1;
                break;
        }
    }

    static void quesEleven(string q11, Scores scores)
    {
        string q11Final = q11.Trim().ToLower();
        switch (q11Final)
        {
            case "create a detailed plan and checklist":
                scores.AttentionToDetail += 1;
                break;
            case "think about the big picture and overall strategy":
                scores.StrategicThinking += 1;
                break;
            case "come up with creative ideas to make it exciting":
                scores.Creativity += 1;
                break;
            case "talk to others to gather their input and build a team":
                scores.RelationshipBuilding += 1;
                break;
        }
    }

    static void quesTwelve(string q12, Scores scores)
    {
        string q12Final = q12.Trim().ToLower();
        switch (q12Final)
        {
            case "i like structured lessons and clear instructions":
                scores.StrategicThinking += 1;
                break;
            case "i learn best through hands-on experience":
                scores.Practical += 1;
                break;
            case "i enjoy discussing and collaborating with others":
                scores.Communication += 1;
                break;
            case "i prefer figuring things out on my own":
                scores.SelfReliance += 1;
                break;
        }
    }

    static void quesThirteen(string q13, Scores scores)
    {
        string q13Final = q13.Trim().ToLower();
        switch (q13Final)
        {
            case "planning and organizing events or projects":
                scores.OrganizationalSkills += 1;
                break;
            case "persuading others to see your point of view":
                scores.Persuasive += 1;
                break;
            case "creating new products or solutions":
                scores.Creativity += 1;
                break;
            case "analyzing data to find trends and insights":
                scores.AnalyticalSkills += 1;
                break;
        }
    }

    static void quesFourteen(string q14, Scores scores)
    {
        string q14Final = q14.Trim().ToLower();
        switch (q14Final)
        {
            case "not important at all":
                // No points for Low Alignment
                break;
            case "slightly important":
                scores.Alignment += 0.25;
                break;
            case "moderately important":
                scores.Alignment += 0.5;
                break;
            case "important":
                scores.Alignment += 0.75;
                break;
            case "extremely important":
                scores.Alignment += 1;
                break;
        }
    }

    static void quesFifteen(string q15, Scores scores)
    {
        string q15Final = q15.Trim().ToLower();
        switch (q15Final)
        {
            case "leading a team to achieve goals":
                scores.Leadership += 1;
                break;
            case "developing strategies and plans":
                scores.StrategicThinking += 1;
                break;
            case "implementing and executing plans":
                scores.DecisionMaking += 1;
                break;
            case "researching and analyzing information":
                scores.CriticalThinking += 1;
                break;
            case "engaging with customers and clients":
                scores.Communication += 1;
                break;
        }
    }

    static void quesSixteen(string q16, Scores scores)
    {
        string q16Final = q16.Trim().ToLower();
        switch (q16Final)
        {
            case "structured career path":
                scores.OrganizationalSkills += 1;
                break;
            case "exploratory path":
                scores.Flexibility += 1;
                break;
            case "a mix of both":
                scores.Balance += 1;
                break;
            case "unsure":
                scores.ProblemSolving += 0;
                break;
        }
    }

    static void quesSeventeen(string q17, Scores scores)
    {
        string q17Final = q17.Trim().ToLower();
        switch (q17Final)
        {
            case "extremely not eager":
                // No points for Low Leadership
                break;
            case "uneager":
                scores.Leadership += 0.25;
                break;
            case "neutral":
                scores.Leadership += 0.5;
                break;
            case "eager":
                scores.Leadership += 0.75;
                break;
            case "extremely eager":
                scores.Leadership += 1;
                break;
        }
    }

    static void quesEighteen(string q18, Scores scores)
    {
        string q18Final = q18.Trim().ToLower();
        switch (q18Final)
        {
            case "lack of mentorship and guidance":
                scores.RelationshipBuilding += 1;
                break;
            case "limited networking opportunities":
                scores.Social += 1;
                break;
            case "financial constraints for further education":
                scores.Rational += 1;
                break;
            case "uncertain job market":
                scores.Resilience += 1;
                break;
            case "skill gaps and lack of experience":
                scores.Persistence += 1;
                break;
        }
    }

    class Scores
    {
        public double Accuracy { get; set; }
        public double Adaptability { get; set; }
        public double Alignment { get; set; }
        public double AnalyticalSkills { get; set; }
        public double AttentionToDetail { get; set; }
        public double Balance { get; set; }
        public double Collaboration { get; set; }
        public double Communication { get; set; }
        public double CriticalThinking { get; set; }
        public double Creativity { get; set; }
        public double DecisionMaking { get; set; }
        public double Empathy { get; set; }
        public double Flexibility { get; set; }
        public double Integrity { get; set; }
        public double Leadership { get; set; }
        public double OrganizationalSkills { get; set; }
        public double Persistence { get; set; }
        public double Practical { get; set; }
        public double Precision { get; set; }
        public double ProblemSolving { get; set; }
        public double Rational { get; set; }
        public double RelationshipBuilding { get; set; }
        public double Resilience { get; set; }
        public double SelfReliance { get; set; }
        public double Social { get; set; }
        public double StrategicThinking { get; set; }
        public double Persuasive { get; set; }
        public double Vision { get; set; }
    }
}
