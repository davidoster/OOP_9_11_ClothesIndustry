using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Models
{
    public class FabricType : IEquatable<FabricType>
    {
        private string _name;
        public string Name { 
            get 
            {
                return _name;
            } 
            
            set 
            {
                _name = NameValidation(value);
            }  
        }

        public FabricType(string name) // CoTTon --> COTTON
        {
            this.Name = NameValidation(name);
        }

        private string NameValidation(string name)
        {
            string result = name.ToUpper();
            return result;

        }

        public override bool Equals(object obj)
        {
            bool result = ((FabricType)obj)._name == _name && ((FabricType)obj).Name == Name;
            return result;
 
            /*
             * bool result = false;
            FabricType objFabricType = (FabricType)obj;

            if (_name == objFabricType._name)
            {
                result = true;
            }

            return result;
             * 
             */

            //return obj is FabricType type &&
            //       _name == type._name &&
            //       Name == type.Name;
        }

        public bool Equals(FabricType other)
        {
            return other != null &&
                   _name == other._name &&
                   Name == other.Name;
        }

        public override int GetHashCode()
        {
            int hashCode = -858915621;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }

        public static bool operator ==(FabricType left, FabricType right)
        {
            return EqualityComparer<FabricType>.Default.Equals(left, right);
        }

        public static bool operator !=(FabricType left, FabricType right)
        {
            return !(left == right);
        }

        public override string ToString()
        {

            return $"FabricType: Name-{Name}";
        }
    }
}
