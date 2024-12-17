public class MyClass {
    public int? MyProperty { get; set; }

    public void MyMethod() {
        // Check for null before accessing the property
        int value = MyProperty.HasValue ? MyProperty.Value.GetHashCode() : 0; 
    }
}