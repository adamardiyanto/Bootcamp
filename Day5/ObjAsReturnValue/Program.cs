class MyCargo {
    public Car _cargoCar;
    private  Motor _cargoMotor;
    private int _cargoWeight;

    public MyCargo(Car cargoCar, Motor cargoMotor){
        _cargoCar = cargoCar;
        _cargoMotor = cargoMotor;
        _cargoWeight = 3000;
    }

    public int checkWeight(){
        return _cargoWeight;
    }

    public Car checkCargoCar(){
        return _cargoCar;
    }

    public Motor checkCargoMotor(){
        return _cargoMotor;
    }
}

class Car {
    private string _carName;

    public Car(string carName){
        _carName = carName;
    }

    public string getBrandName(){
        return _carName;
    }
}

class Motor {
    private string _motorName;

    public Motor(string motorName){
        _motorName = motorName;
    }

    public string getBrandName(){
        return _motorName;
    }
}

class Program {
    static void Main(string[] args) {
        Motor myMotor = new Motor("Honda");
        Car myCar = new Car("Mitsubishi");

        MyCargo myCargo = new MyCargo(myCar, myMotor);

        int cargoWeight = myCargo.checkWeight();
        Car newCar = myCargo.checkCargoCar();
        Motor newMotor = myCargo.checkCargoMotor();

        Console.WriteLine(newCar.getBrandName());
        Console.WriteLine(newMotor.getBrandName());
        Console.WriteLine(myCargo._cargoCar.getBrandName());

    }
}