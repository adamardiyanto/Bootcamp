class MyCargo {
    public Car _cargoCar;
    private  Motor _cargoMotor;
    private int _cargoWeight;

    public MyCargo(Car cargoCar, Motor cargoMotor){
        _cargoCar = cargoCar;
        _cargoMotor = cargoMotor;
        _cargoWeight = 3000;
    }

    public int CheckWeight(){
        return _cargoWeight;
    }

    public Car CheckCargoCar(){
        return _cargoCar;
    }

    public Motor CheckCargoMotor(){
        return _cargoMotor;
    }
}

class Car {
    private string _carName;

    public Car(string carName){
        _carName = carName;
    }

    public string GetBrandName(){
        return _carName;
    }
}

class Motor {
    private string _motorName;

    public Motor(string motorName){
        _motorName = motorName;
    }

    public string GetBrandName(){
        return _motorName;
    }
}

class Program {
    static void Main(string[] args) {
        Motor myMotor = new Motor("Honda");
        Car myCar = new Car("Mitsubishi");

        MyCargo myCargo = new MyCargo(myCar, myMotor);

        int cargoWeight = myCargo.CheckWeight();
        Car newCar = myCargo.CheckCargoCar();
        Motor newMotor = myCargo.CheckCargoMotor();

        Console.WriteLine(newCar.GetBrandName());
        Console.WriteLine(newMotor.GetBrandName());
        Console.WriteLine(myCargo._cargoCar.GetBrandName()); 
        

    }
}