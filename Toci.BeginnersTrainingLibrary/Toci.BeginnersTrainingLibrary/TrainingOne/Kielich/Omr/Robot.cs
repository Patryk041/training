using System.Reflection.Emit;

namespace Toci.BeginnersTrainingLibrary.TrainingOne.Kielich.Omr
{
    public class Robot : Machine
    {
        // Mialem zrobic components dependency, ze jak cos nie pracuje
        // lub brak polaczenia to wywala Error, ale juz sie nie chce ;)

        // UML: http://www.docdroid.net/wmpp/robot.pdf.html

        ElectricEngine engine = new ElectricEngine();
        Sensor sensor = new Sensor();
        Effector effector = new Effector();
        Computer computer = new Computer();


        public override bool IsConnected()
        {
            return battery.IsConnected() && engine.IsConnected() && sensor.IsConnected() &&
                   computer.IsConnected();
        }

        public override bool IsWorking()
        {
            return engine.IsWorking() && computer.IsWorking() && Work;
        }

        public override bool SetConnection(bool connection)
        {
            return battery.SetConnection(connection) && engine.SetConnection(connection) && computer.SetConnection(connection) && sensor.SetConnection(connection);
        }

        public override bool SetWork(bool work)
        {
            Work = work;
            return engine.SetWork(work) && computer.SetWork(work);
        }

        public bool Move(bool move)
        {
            return computer.IsMoving(effector.DoMove(move));
        }

        public bool Stop(bool stop)
        {
            return computer.IsIdle(effector.DoStop(stop));
        }

        public bool Jump(bool jump)
        {
            return computer.IsJumping(effector.DoJump(jump));
        }

        public bool Take(bool take)
        {
            return computer.IsTaking(effector.DoTake(take));
        }

        public bool Damage(bool damage)
        {
            return computer.IsDamaging(effector.DoDamage(damage));
        }

        public bool Run(bool run)
        {
            return computer.IsRunning(effector.DoRun(run));
        }

        public bool Scan(bool scan)
        {
            return sensor.IsScanning(effector.DoScan(scan));
        }

        public bool Record(bool record)
        {
            return sensor.IsRecording(effector.DoRecord(record));
        }

        public override bool IsEnough()
        {
            return base.IsEnough() && engine.IsEnough();
        }

        public bool SetCapacity(int currency)
        {
           return battery.Capacity(currency);
        }

        public bool SetVoltage(int volt)
        {
           return engine.Voltage(volt);
        }
    }
}
