namespace TFLCollection;

public class Stack:ICloneable{

    private int size;
    private int[] arr;
    public Stack(int s){
        this.size=s;
        this.arr=new int[size];
    }

    public object Clone(){
        Stack replica=new Stack(this.size);
        this.arr.CopyTo(replica,arr,0);
        return replica;
        
    }
}