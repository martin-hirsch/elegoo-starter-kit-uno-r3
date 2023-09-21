using System.Device.Gpio;

const int pin = 18;
var controller = new GpioController();
controller.OpenPin(pin, PinMode.Output);

while (true)
{
    controller.Write(pin, PinValue.High);
    Thread.Sleep(200);
    controller.Write(pin, PinValue.Low);
    Thread.Sleep(200);
}