using System;

namespace command_pattern
{
    // Tạo một giao diện
    public interface ILight
    {
        // Phương thức thực hiện yêu cầu
        void Execute();
        // Phương thức hoàn tác yêu cầu
        void Undo();
    }

    // Lớp nhận yêu cầu
    public class Light
    {
        private bool _isOn;

        public Light(bool isOn)
        {
            _isOn = isOn;
        }

        public void TurnOn()
        {
            _isOn = true;
            Console.WriteLine("Light on");
        }

        public void TurnOff()
        {
            _isOn = false;
            Console.WriteLine("Light off");
        }
    }
    // bật đèn - triển khai interface
    public class LightOn : ILight
    {
        private Light _light;

        public LightOn(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOn();
        }

        public void Undo()
        {
            _light.TurnOff();
        }
    }

    public class LightOff : ILight
    {
        private Light _light;

        public LightOff(Light light)
        {
            _light = light;
        }

        public void Execute()
        {
            _light.TurnOff();
        }

        public void Undo()
        {
            _light.TurnOn();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light(true);
            ILight lightOn = new LightOn(light);
            ILight lightOff = new LightOff(light);

            lightOn.Execute(); // Output: Light on
            lightOff.Execute(); // Output: Light off
            Console.ReadLine();
        }
    }
}