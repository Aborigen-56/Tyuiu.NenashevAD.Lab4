namespace FitnessCalc.Lib
{
    public class FitnessCalcLib
    {
        public double CalculateBMI(double weightKg, double heightM)
        {
            if (heightM <= 0)
            {
                throw new ArgumentException("Height must be greater than zero.");
            }
            return weightKg / (heightM * heightM);
        }

        public (double Calories, double Proteins, double Fats, double Carbohydrates) CalculateBMR(double weightKg, double heightCm, int age, string gender, string activityLevel)
        {
            double bmr = 0;
            if (gender.ToLower() == "male")
            {
                bmr = 88.362 + (13.397 * weightKg) + (4.799 * heightCm) - (5.677 * age);
            }
            else if (gender.ToLower() == "female")
            {
                bmr = 447.593 + (9.247 * weightKg) + (3.098 * heightCm) - (4.330 * age);
            }
            else
            {
                throw new ArgumentException("Invalid gender. Use 'male' or 'female'.");
            }

            double activityMultiplier = 1.2;
            switch (activityLevel.ToLower())
            {
                case "light":
                    activityMultiplier = 1.375;
                    break;
                case "moderate":
                    activityMultiplier = 1.55;
                    break;
                case "active":
                    activityMultiplier = 1.725;
                    break;
                case "very active":
                    activityMultiplier = 1.9;
                    break;
            }

            double calories = bmr * activityMultiplier;
            double proteins = calories * 0.3 / 4;
            double fats = calories * 0.25 / 9;
            double carbohydrates = calories * 0.45 / 4;

            return (calories, proteins, fats, carbohydrates);
        }
    }
}
