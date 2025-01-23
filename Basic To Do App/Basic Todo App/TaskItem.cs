namespace Basic_Todo_App
{
    public class TaskItem
    {
        public string Task { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }

        public override string ToString()
        {
            if (IsCompleted)
            {
                return $"{DueDate.ToShortDateString()} - {Task} (Completed)";
            }
            return $"{DueDate.ToShortDateString()} - {Task}";
        }
    }
}
