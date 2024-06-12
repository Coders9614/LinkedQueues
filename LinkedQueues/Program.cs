using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedQueues
{
    public class Program
    {
        public class LinkedListQueue<T>
        {
            private LinkedList<T> list = new LinkedList<T>();

            public void Enqueue(T item)
            {
                list.AddLast(item);
                
            }

            public T Dequeue()
            {
                if (list.Count == 0)
                {
                    Console.WriteLine("The queue is empty. Cannot dequeue.");
                    return default(T);
                }

                T value = list.First.Value;
                RemoveFirst();
                return value;
            }

            private void RemoveFirst()
            {
                if (list.Count > 0)
                {
                    list.RemoveFirst();
                }
            }

            public int Count
            {
                get { return list.Count; }
            }

            public void DisplayQueue()
            {
                if (list.Count == 0)
                {
                    Console.WriteLine("The queue is empty.");
                }
                else
                {
                    foreach (var item in list)
                    {
                        Console.WriteLine(item);
                    }
                }
            }

            public bool IsNotEmpty()
            {
                return list.Count > 0;
            }
        }
        static void EnqueueCustomers(LinkedListQueue<Customer> queue)
        {
            queue.Enqueue(new Customer { CustomerId = 1, CustomerFName = "Smith", CustomerLName = "Kim", Address = "1234 Main St", PhoneNumber = "212-555-1234" });
            queue.Enqueue(new Customer { CustomerId = 2, CustomerFName = "Jane", CustomerLName = "Peter", Address = "4569 TwoSt", PhoneNumber = "201-555-5678" });
            queue.Enqueue(new Customer { CustomerId = 3, CustomerFName = "Alice", CustomerLName = "Johnson", Address = "78911 Three St", PhoneNumber = "201-555-8765" });
            queue.Enqueue(new Customer { CustomerId = 4, CustomerFName = "James", CustomerLName = "Lee", Address = "3212 Four St", PhoneNumber = "732-555-4321" });
            queue.Enqueue(new Customer { CustomerId = 5, CustomerFName = "Charlie", CustomerLName = "Davis", Address = "6543 Five St", PhoneNumber = "800-555-6543" });
        }
        //Overrides ToString method
        //to return a formated string of the customer’s values
        static void DequeueCustomers(LinkedListQueue<Customer> queue)
        {
            var dequeuedCustomer = queue.Dequeue();
            if (dequeuedCustomer != null)
            {
                Console.WriteLine($"Dequeued: {dequeuedCustomer}");
            }
        }
        static void Main()
        {
            // Create a LinkedListQueue for customers 
            LinkedListQueue<Customer> call = new LinkedListQueue<Customer>();

            // Enqueue customers
            EnqueueCustomers(call);

            // Display the queue
            Console.WriteLine("Customers in the call queue:");
            call.DisplayQueue();

            // Dequeue customers
            DequeueCustomers(call);

            // Display the queue , remove the dequeue
            Console.WriteLine("Customers in the call queue after dequeuing:");
            call.DisplayQueue();
            Console.ReadKey();
        }
     }
}
    

