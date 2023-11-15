using System;
public class Task
{
    private string title;
    private string description;
    DateTime limitDate;
    bool complete;
    public Task(string title, string description, DateTime limitDate) {
        this.title = title;
        this.description = description;
        this.limitDate = limitDate;
        this.complete = false;
    }
    public void setTitle(string title){
        this.title = title;
    }
    public string getTitle(){
        return this.title;
    }
    public void setDescription(string description){
        this.description = description;
    }
    public string getDescription(){
        return this.description;
    }
    public void setLimitDate(DateTime limitDate){
        this.limitDate = limitDate;
    }
    public DateTime getLimitDate(){
        return this.limitDate;
    }
    public void setComplete(bool complete){
        this.complete = complete;
    }
    public bool getComplete(){
        return this.complete;
    }

    public static void showTask(List<Task> taskList){
        int id = 0;
        Console.WriteLine("<----------TASKS---------->");
        foreach(Task task in taskList){
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Title: {task.getTitle()}");
            Console.WriteLine($"Description: {task.getDescription()}");
            Console.WriteLine($"Limit Date: {task.getLimitDate()}");
            Console.WriteLine($"Status: {(task.getComplete()? "Complete" : "Incomplete")}");
            id++;
        }
    }
    
    public static void incompleteTasks(List<Task> taskList){
        Console.WriteLine("<----------INCOMPLETE TASKS---------->");
        foreach(Task task in taskList){
            if(task.getComplete() == false){
                Console.WriteLine($"Title: {task.getTitle()}");
                Console.WriteLine($"Description: {task.getDescription()}");
                Console.WriteLine($"Limit Date: {task.getLimitDate()}");
            }
        }
    }
    public static void completeTasks(List<Task> taskList){
        Console.WriteLine("<----------COMPLETE TASKS---------->");
        foreach(Task task in taskList){
            if(task.getComplete() == true){
                Console.WriteLine($"Title: {task.getTitle()}");
                Console.WriteLine($"Description: {task.getDescription()}");
                Console.WriteLine($"Limit Date: {task.getLimitDate()}");
            }
        }
    }

    public static int getCompleteTasks(List<Task> taskList){
        int i = 0;
        foreach(Task task in taskList){
            if(task.getComplete() == true)
                i++;
        }
        return i;
    }

    public static int getIncompleteTasks(List<Task> taskList){
        int i = 0;
        foreach(Task task in taskList){
            if(task.getComplete() == false)
                i++;
        }
        return i;
    }
    public static void lastTask(List<Task> taskList){
        if(taskList.Count > 0){
            Task find = taskList[taskList.Count - 1];
            Console.WriteLine($"Title: {find.getTitle()}");
            Console.WriteLine($"Description: {find.getDescription()}");
            Console.WriteLine($"Limit Date: {find.getLimitDate()}");
        }
        
    }
    public static void firstTask(List<Task> taskList){
        if(taskList.Count > 0){
            Task find = taskList[0];
            Console.WriteLine($"Title: {find.getTitle()}");
            Console.WriteLine($"Description: {find.getDescription()}");
            Console.WriteLine($"Limit Date: {find.getLimitDate()}");
        }
    }
}