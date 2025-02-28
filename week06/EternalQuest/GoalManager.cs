using System.Data;
using System.IO; 
public class GoalManager{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public GoalManager(){}
    public void Start(){
    // This is the "main" function for this class. It is called by Program.cs, and then runs the menu loop
        string choice = "";
        do{
            // Console.Clear();
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }

            else if(choice == "2")
            {
                ListGoalDetails();
            }

            else if(choice == "3")
            {
                SaveGoals();
            }

            else if(choice == "4")
            {
                LoadGoals();
            }

            else if(choice == "5")
            {
                RecordEvent();
            }
            
        }while(choice != "6");
    }

    public void DisplayPlayerInfo(){
    // Displays the players current score.
        Console.WriteLine($"\nYou have {_score} points.");
        string level = "";
        List<string> levels = new List<string>{"Beginner", "Novice", "Apprentice", "Adept", "Expert", "Master", "Grandmaster", "Legend", "Mythic", "Ulitmate"};
        if(_score < 250)
        {
            Console.WriteLine($"Achieve 250 points to level up\n");
        }
        else 
        {
            int number = (_score / 250) -1;
            if (number >=levels.Count)
            {
                number = levels.Count -1;
            }
            level = levels[number];
            Console.WriteLine($"Congratulations! You are now a {level}\n");
        }
    }

    public void ListGoalNames(){
    // Lists the names of each of the goals.
        int indice = 0;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{indice + 1}. {_goals[indice].GetName()}");
            indice ++;
        }
    }

    public void ListGoalDetails(){
    //  Lists the details of each goal (including the checkbox of whether it is complete).
        Console.Clear();
        Console.WriteLine("The goals are:");
        int indice = 0;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{indice + 1}. {_goals[indice].GetDetailsString()}");
            indice ++;
        }
    }

    public void CreateGoal(){
    // Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
        Console.Clear();
        Console.WriteLine("\nThe types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string secondChoice = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        if (secondChoice == "1")
        {
            _goals.Add(new SimpleGoal(name, description, points));
        }
        else if (secondChoice == "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        else if (secondChoice == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));

        }
        else
        {
            Console.WriteLine("Invalid option");
        }
    }

    public void RecordEvent(){
    // Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
        Console.Clear();
        Console.WriteLine("\nGoals:");
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int numGoal = int.Parse(Console.ReadLine()) - 1;
        if (numGoal >= 0 && numGoal < _goals.Count)
        {
            _goals[numGoal].RecordEvent(ref _score);
            Console.WriteLine($"Congratulations! You have earned {_score} points!");
        }
    }

    public void SaveGoals(){
    // Saves the list of goals to a file.
        Console.Write("What is the filename for the goal file? ");
        string file = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);
            foreach(Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(){
    // Loads the list of goals from a file.
        Console.Write("What is the filename for the goal file? ");
        string file = Console.ReadLine();
        _goals.Clear();
        using (StreamReader outputFile = new StreamReader(file))
        {
            _score = int.Parse(outputFile.ReadLine());
            string line;
            while((line = outputFile.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts[0] == "SimpleGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool IsComplete = bool.Parse(parts[4]);

                    SimpleGoal goal = new SimpleGoal(name, description, points);
                    if (IsComplete) goal.RecordEvent(ref _score);
                    _goals.Add(goal);
                }

                else if (parts[0] == "EternalGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    EternalGoal goal = new EternalGoal(name, description, points);
                    _goals.Add(goal);
                }

                else if (parts[0] == "ChecklistGoal")
                {
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    int target = int.Parse(parts[4]);
                    int bonus = int.Parse(parts[5]);
                    
                    ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
                    _goals.Add(goal);
                }
            }
        }
    }
    
}