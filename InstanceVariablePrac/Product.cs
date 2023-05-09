namespace InstanceVariablePrac
{
    internal class Product
    {
        public static string origin = "대한민국"; // 클래스변수
        public string name= "default"; // 인스턴스 변수
        public int price = 0; // 인스턴스 변수

        public override string ToString()
        {
            return "이름 : " + this.name + " / 가격 : " + this.price; 
        }
    }
}