using TechReeds.DataAccess.Entities;

namespace TechReeds.DataAccess.Data
{
    static class DataSeed
    {
        public static List<Category> LoadCategories()
        {
            return new List<Category>
            {
                // Software Engineering
                new Category { Id = 1, Name = "Algorithms", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Clean Code", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Competitive Programming", DisplayOrder = 3 },
                new Category { Id = 4, Name = "Computer Science", DisplayOrder = 4 },
                new Category { Id = 5, Name = "Databases", DisplayOrder = 5 },
                new Category { Id = 6, Name = "Design Patterns", DisplayOrder = 6 },
                new Category { Id = 7, Name = "Domain-Driven Design", DisplayOrder = 7 },
                new Category { Id = 8, Name = "Functional Programming", DisplayOrder = 8 },
                new Category { Id = 9, Name = "Object-Oriented Programming", DisplayOrder = 9 },
                new Category { Id = 10, Name = "Refactoring", DisplayOrder = 10 },
                new Category { Id = 11, Name = "Unit Testing", DisplayOrder = 11 },

                // Technology
                new Category { Id = 12, Name = "Android", DisplayOrder = 12 },
                new Category { Id = 13, Name = "Angular", DisplayOrder = 13 },
                new Category { Id = 14, Name = "Assembly", DisplayOrder = 14 },
                new Category { Id = 15, Name = "Blockchain", DisplayOrder = 15 },
                new Category { Id = 16, Name = "C Language", DisplayOrder = 16 },
                new Category { Id = 17, Name = "C# and .NET", DisplayOrder = 17 },
                new Category { Id = 18, Name = "C++", DisplayOrder = 18 },
                new Category { Id = 19, Name = "Dart", DisplayOrder = 19 },
                new Category { Id = 20, Name = "Flutter", DisplayOrder = 20 },
                new Category { Id = 21, Name = "Go", DisplayOrder = 21 },
                new Category { Id = 22, Name = "HTML & CSS", DisplayOrder = 22 },
                new Category { Id = 23, Name = "iOS", DisplayOrder = 23 },
                new Category { Id = 24, Name = "Java", DisplayOrder = 24 },
                new Category { Id = 25, Name = "JavaScript & jQuery", DisplayOrder = 25 },
                new Category { Id = 26, Name = "Node.js", DisplayOrder = 26 },
                new Category { Id = 27, Name = "PHP", DisplayOrder = 27 },
                new Category { Id = 28, Name = "Python", DisplayOrder = 28 },
                new Category { Id = 29, Name = "React", DisplayOrder = 29 },
                new Category { Id = 30, Name = "React Native", DisplayOrder = 30 },
                new Category { Id = 31, Name = "Ruby", DisplayOrder = 31 },
                new Category { Id = 32, Name = "Scala", DisplayOrder = 32 },
                new Category { Id = 33, Name = "TypeScript", DisplayOrder = 33 },
                new Category { Id = 34, Name = "Vue.js", DisplayOrder = 34 },
                new Category { Id = 35, Name = "Xamarin", DisplayOrder = 35 },

                // AI & Data Science
                new Category { Id = 36, Name = "Artificial Intelligence", DisplayOrder = 36 },
                new Category { Id = 37, Name = "Big Data", DisplayOrder = 37 },
                new Category { Id = 38, Name = "Computer Vision", DisplayOrder = 38 },
                new Category { Id = 39, Name = "Data Analysis", DisplayOrder = 39 },
                new Category { Id = 40, Name = "Data Science", DisplayOrder = 40 },
                new Category { Id = 41, Name = "Data Visualization", DisplayOrder = 41 },
                new Category { Id = 42, Name = "Deep Learning", DisplayOrder = 42 },
                new Category { Id = 43, Name = "Machine Learning", DisplayOrder = 43 },
                new Category { Id = 44, Name = "Mathematics", DisplayOrder = 44 },
                new Category { Id = 45, Name = "NLP", DisplayOrder = 45 },
                new Category { Id = 46, Name = "Power BI", DisplayOrder = 46 },
                new Category { Id = 47, Name = "R Programming", DisplayOrder = 47 },
                new Category { Id = 48, Name = "Statistics", DisplayOrder = 48 },

                // Hardware
                new Category { Id = 49, Name = "Arduino", DisplayOrder = 49 },
                new Category { Id = 50, Name = "ARM", DisplayOrder = 50 },
                new Category { Id = 51, Name = "Embedded Linux", DisplayOrder = 51 },
                new Category { Id = 52, Name = "Embedded Systems", DisplayOrder = 52 },
                new Category { Id = 53, Name = "PIC Microcontrollers", DisplayOrder = 53 },
                new Category { Id = 54, Name = "Raspberry Pi", DisplayOrder = 54 },

                // Security
                new Category { Id = 55, Name = "Cybersecurity", DisplayOrder = 55 }
            };
        }

    }
}
