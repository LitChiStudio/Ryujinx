namespace Ryujinx.HLE.HOS.Kernel.Threading
{
    class KEvent
    {
        public KReadableEvent ReadableEvent { get; private set; }
        public KWritableEvent WritableEvent { get; private set; }

        public KEvent(Horizon system)
        {
            ReadableEvent = new KReadableEvent(system);
            WritableEvent = new KWritableEvent(system, this);
        }
    }
}