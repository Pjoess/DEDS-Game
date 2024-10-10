namespace BordModel{

    class Stapel<T>{

        public Element top;
        
        public Stapel(){
            top = null;
        }

        public T getElement() {
            return this.top.data;
        }

        public void duw(T data){
            Element element  = new Element(data);
            element.volgende = top;
            top = element;
        }

        public T pak(){

            if (top == null)
            {
                throw new InvalidOperationException("Stapel is leeg");
            }
            T value = top.data;
            top = top.volgende;

            return value;
        }




        public class Element{
            public Element volgende;
            public T data;

            public Element(T data){
                this.data = data;
                this.volgende = null;
            }
        }
    }
}