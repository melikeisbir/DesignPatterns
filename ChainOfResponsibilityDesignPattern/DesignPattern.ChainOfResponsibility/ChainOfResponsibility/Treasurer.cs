﻿using DesignPattern.ChainOfResponsibility.DAL;
using DesignPattern.ChainOfResponsibility.Models;

namespace DesignPattern.ChainOfResponsibility.ChainOfResponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel req)
        {
            Context context = new Context();
            if (req.Amount <= 100000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Veznedar - Bahar";
                customerProcess.Description = "Para çekme işlemi onaylandı, müşteriye talep ettiği tutar ödendi.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = req.Amount.ToString();
                customerProcess.Name = req.Name;
                customerProcess.EmployeeName = "Veznedar - Bahar";
                customerProcess.Description = "Para çekme tutarı veznedarın günlük ödeyebileceği limiti aştığı için işlem şube müdür yardımcısına yönlendirildi.";
                context.CustomerProcesses.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(req);
            }
        }
    }
}
