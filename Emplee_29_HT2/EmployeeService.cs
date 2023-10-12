using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//EmployeeService servicedan foydalaning

//unda HireAsync(firstname, lastname, emailAddress) methodi bo'lsin

//bunda 
//- xodimga confirmation email jo'nating 
//- email jo'natilgungacha $"{firstname} {lastname}`s employment contract.docs" faylini yarating
//- confirmation email jo'natib bo'lingach, welcome on board email ni jo'nating
//- fayl yaratib bo'lingach ichiga employment contract textini yozib qo'ying
//- welcome on board email jo'natib bo'lingach, office policies emailini jo'nating


namespace Emplee_29_HT2
{
    internal class EmployeeService
    {
        private EmailService _emailService;

        public EmployeeService()
        {
            _emailService = new EmailService();
        }

        public async Task HireAsync(Employee employee)
        {
            string fullName = $"{employee.FirstName} {employee.LastName}";
            string path = $"{employee.FirstName} {employee.LastName}`s employment contract.docx";

            //Confirmation email jo'natish
            var confirmationEmailTask = Task.Run(async () =>
            {
                return await _emailService.SendAsync(employee.EmailAddress, "Confirm you account", "Enter to this link", fullName);
            });
            // Creating File

            var createFile = Task.Run(() =>
            {
                var fileName = File.Create(path);
                fileName.Close();
                return fileName;
            });

            //- email jo'natilgungacha $"{firstname} {lastname}`s employment contract.docs" faylini yarating
            var createDocxFile = await createFile;
            await File.WriteAllTextAsync(path, $"FirstName : {employee.FirstName}\tLastName : {employee.LastName} employment conctarct");

            //- confirmation email jo'natib bo'lingach, welcome on board email ni jo'nating
            await confirmationEmailTask;
            var secondEmailTask = Task.Run(async () =>
            {
                return await _emailService.SendAsync(employee.EmailAddress, employee.FirstName, "Welcome to board",  fullName);
            });

            await secondEmailTask;
            var lastEmailTask = Task.Run(() =>
            {
                return _emailService.SendAsync(employee.EmailAddress, "", "office policies", fullName);
            });
        }
    }
}
