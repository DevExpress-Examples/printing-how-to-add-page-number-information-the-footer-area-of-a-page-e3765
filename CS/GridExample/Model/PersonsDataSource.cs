// Developer Express Code Central Example:
// Printing: How to add page number information the footer area of a page
// 
// This example shows how to add a page number to every page when printing a
// DXGrid. You'll need to prepare a custom page footer template and place a
// TextEdit control that will display the current page number within it. Note that
// the TextEdit should be properly adjusted by setting required dxp:ExportSettings
// (http://documentation.devexpress.com/#WPF/DevExpressXpfPrintingExportSettingsMembersTopicAll),
// dxp:PageNumberExportSettings.Kind
// (http://documentation.devexpress.com/#WPF/DevExpressXpfPrintingPageNumberExportSettings_Kindtopic)
// and dxp:PageNumberExportSettings.Format
// (http://documentation.devexpress.com/#WPF/DevExpressXpfPrintingPageNumberExportSettings_Formattopic)
// properties. Next, assign this custom page footer template to the
// PrintableControlLink.PageFooterTemplate property during export.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3765

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace GridExample {
    public class PersonsViewModel {
        ObservableCollection<Person> persons;
        
        public PersonsViewModel() {
            List<string> Names = new List<string> { "Alex", "Alice", "Tony", "Den", "Andrew", "John", "Donald", "Brian", "Effy", "Lisa", "Matthew" };
            persons = new ObservableCollection<Person>();
            for (int i = 0; i < 500; i++) {
                persons.Add(new Person(Names[i%10], "Last name " + i, 21 + i, i % 2 == 0, 170 + i, 75 + i));
            }
            persons[5].Age = 22;
            persons[8].Age = 50;
        }

        public ObservableCollection<Person> Persons {
            get {
                return persons;
            }
        }
    }

    public class Person : INotifyPropertyChanged, IDataErrorInfo {
        const string lastNamePropertyName = "LastName";
        const string firstNamePropertyName = "FirstName";
        const string agePropertyName = "Age";
        const string heightPropertyName = "IsMarried";
        const string isMarriedPropertyName = "Height";
        const string weightPtropertyName = "Weight";

        string firstName;
        string lastName;
        int age;
        bool isMarried;
        int height;
        int weight;
        PersonPropertiesValidator Validator = new PersonPropertiesValidator();

        public Person() { }

        public Person(string firstName, string lastName, int age, bool isMarried, int height, int weight) {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            IsMarried = isMarried;
            Weight = weight;
            Height = height;
        }

        public string FirstName {
            get {
                return firstName;
            }
            set {
                Validator.IsNameValid(value, firstNamePropertyName);
                firstName = value;
                RaisePropertyChanged(firstNamePropertyName);
            }
        }

        public string LastName {
            get {
                return lastName;
            }
            set {
                Validator.IsNameValid(value, lastNamePropertyName);
                lastName = value;
                RaisePropertyChanged(lastNamePropertyName);
            }
        }

        public int Age {
            get {
                return age;
            }
            set {
                Validator.IsAgeValid(value, agePropertyName);
                age = value;
                RaisePropertyChanged(agePropertyName);
            }
        }

        public bool IsMarried {
            get {
                return isMarried;
            }
            set {
                isMarried = value;
                RaisePropertyChanged(isMarriedPropertyName);
            }
        }

        public int Height {
            get {
                return height;
            }
            set {
                height = value;
                RaisePropertyChanged(heightPropertyName);
            }
        }

        public int Weight {
            get {
                return weight;
            }
            set {
                weight = value;
                RaisePropertyChanged(weightPtropertyName);
            }
        }

        #region INotifyPropertyChanged members
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName) {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region IDataErrorInfo members
        public string Error {
            get {
                return Validator.DataError;
            }
        }

        public string this[string columnName] {
            get {
                if (Validator.DataErrors.ContainsKey(columnName))
                    return Validator.DataErrors[columnName];
                else
                    return null;
            }
        }
        #endregion
    }

    public class PersonPropertiesValidator {
        string dataError = "";
        Dictionary<string, string> dataErrors = new Dictionary<string, string>();

        public bool IsNameValid(string value, string propertyName) {
            if (string.IsNullOrEmpty(value)) {
                dataErrors[propertyName] = "Full name is required.";
                return false;
            } else {
                ClearPropertyErrors(propertyName);
                return true;
            }
        }

        public bool IsAgeValid(int value, string propertyName) {
            if (value <= 0) {
                dataErrors[propertyName] = "Age validation failed.";
                return false;
            } else {
                ClearPropertyErrors(propertyName);
                return true;
            }
        }

        public string DataError {
            get {
                return dataError;
            }
        }

        public Dictionary<string, string> DataErrors {
            get {
                return dataErrors;
            }
        }

        void ClearPropertyErrors(string propertyName) {
            if (dataErrors.ContainsKey(propertyName))
                dataErrors.Remove(propertyName);
        }
    }
}
