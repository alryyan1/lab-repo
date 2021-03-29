namespace lab_repo
{
    public class person
    {
        public string Name {get;set;}
        public System.DateTime DateOfBirth {get;set;}
        public virtual void SayHellow()
        {
            System.Console.WriteLine(   "Hellow");
        }
        
        
    }
}