namespace autofac_console
{
   public  class DateWriter
    {
       private readonly IDateWriter dateWriter;

       public DateWriter(IDateWriter dateWriter)
       {
           this.dateWriter = dateWriter;
       }

       public void Write()
       {
           dateWriter.WriteDate();
       }
    }
}
