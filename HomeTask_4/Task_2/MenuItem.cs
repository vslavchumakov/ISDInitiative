namespace Task_2
{
    enum FirstMenuItem : byte
    {
        /// <summary>
        /// Exit
        Exit = 0,

        /// <summary>
        /// Start playing
        /// </summary>
        Play=1,

        /// <summary>
        /// Start recording
        /// </summary>
        Record = 2,
    }

    enum SecondMenuItem : byte
    {
        /// <summary>
        /// Exit
        Exit = 0,

        /// <summary>
        /// Pause playing or recording
        /// </summary>
        Pause = 1,

        /// <summary>
        /// Stop playing or recording
        /// </summary>
        Stop = 2
    }
}
