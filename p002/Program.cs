using System;
public class Program
{
    public static void Main(string[] args)
    {
        List<Task> taskList = new List<Task>();
        Task task;
        int op;
        do{
            Console.WriteLine("<----------MENU---------->");
            Console.WriteLine("1- New Task");
            Console.WriteLine("2- Show Tasks");
            Console.WriteLine("3- Edit Task");
            Console.WriteLine("4- Delete Task");
            Console.WriteLine("5- See Statistics");
            Console.WriteLine("0- Exit");
            op = Int32.Parse(Console.ReadLine());
            if(op == 1){
                string? title, description, limitDate;
                DateTime date = new DateTime();
                Console.WriteLine("Inform the task's title");
                title = Console.ReadLine();
                Console.WriteLine("Inform the task's description");
                description = Console.ReadLine();
                Console.WriteLine("Inform the task's limit date (DD/MM/YYYY)");
                limitDate = Console.ReadLine();
                date = DateTime.Parse(limitDate);
                task = new Task(title, description, date);
                taskList.Add(task);
            }
            else if(op == 2){
                int op2;
                Console.WriteLine("<----------SHOW TASKS---------->");
                Console.WriteLine("1- All Tasks");
                Console.WriteLine("2- Complete Tasks");
                Console.WriteLine("3- Imcomplete Tasks");
                op2 = Int32.Parse(Console.ReadLine());
                if(op2 == 1)
                    Task.showTask(taskList);
                else if(op2 == 2)
                    Task.completeTasks(taskList);
                else if(op2 == 3)
                    Task.incompleteTasks(taskList);
            }
            else if(op == 3){
                int id;
                Task.showTask(taskList);
                Console.WriteLine("Inform the task's ID");
                id = Int32.Parse(Console.ReadLine());
                taskMenu(taskList, id);
            }
            else if(op == 4){
                int id;
                Task.showTask(taskList);
                Console.WriteLine("Inform the task's ID");
                id = Int32.Parse(Console.ReadLine());
                taskList.Remove(taskList[id]);
            }
            else if(op == 5){
                Console.Write("Complete tasks: ");
                Console.WriteLine(Task.getCompleteTasks(taskList));
                Console.Write("Incomplete tasks: ");
                Console.WriteLine(Task.getIncompleteTasks(taskList));
                Console.WriteLine("First task: ");
                Task.firstTask(taskList);
                Console.WriteLine("Last task: ");
                Task.lastTask(taskList);
            }
        }while(op != 0);

        
    }
    public static void taskMenu(List<Task> taskList, int id){
        int op;
        string information;
        do{
            Console.WriteLine("<----------MENU---------->");
            Console.WriteLine("1- Edit Title");
            Console.WriteLine("2- Edit Description");
            Console.WriteLine("3- Edit Status");
            Console.WriteLine("4- Edit Limit Date");
            Console.WriteLine("0- Exit");

            op = Int32.Parse(Console.ReadLine());
            if(op == 1){
                Console.WriteLine("Inform the new task's title");
                information = Console.ReadLine();
                taskList[id].setTitle(information);
            }
            else if(op == 2){
                Console.WriteLine("Inform the new task's description");
                information = Console.ReadLine();
                taskList[id].setTitle(information);
            }
            else if(op == 3){
                int op2;
                Console.WriteLine("<----------STATUS---------->");
                Console.WriteLine("1- Set as complete");
                Console.WriteLine("2- Set as incomplete");
                op2 = Int32.Parse(Console.ReadLine());
                if(op2 == 1)
                    taskList[id].setComplete(true);
                else if(op2 == 2)
                    taskList[id].setComplete(false);
                
            }
            else if(op == 4){
                DateTime date;
                Console.WriteLine("Inform the new task's limit date (DD/MM/YYYY)");
                information = Console.ReadLine();
                date = DateTime.Parse(information);
                taskList[id].setLimitDate(date);
            }
        }while(op != 0);
    }
        
}