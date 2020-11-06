using System;

namespace hw4es
{
    interface IPlayable
    {
        public void Play();
        public void Pause();
        public void Stop();
    }

    interface IRecordable
    {
        public void Record();
        public void Pause();
        public void Stop();
    }

    class Player : IPlayable, IRecordable
    {
        private bool isPlaying;
        private bool isRecording;
        private bool isPaused;
        private bool isStopped;

        public void Play()
        {
            if (isPlaying)
            {
                Console.WriteLine("Already playing");
                return;
            }

            Console.WriteLine("Started playing");

            isPlaying = true;

            isPaused = false;
            isStopped = false;
            isRecording = false;
        }

        public void Record()
        {
            if (isRecording)
            {
                Console.WriteLine("Already recording");
                return;
            }
            Console.WriteLine("Started playing");

            isRecording = true;

            isPlaying = false;
            isPaused = false;
            isStopped = false;
        }

        public void Pause()
        {
            if (isPaused)
            {
                Console.WriteLine("Already paused");
                return;
            }
            Console.WriteLine("Started playing");

            isPaused = true;

            isPlaying = false;
            isRecording = false;
            isPaused = false;
        }

        public void Stop()
        {
            if (isStopped)
            {
                Console.WriteLine("Already stopped");
                return;
            }

            isStopped = true;

            isPaused = false;
            isPlaying = false;
            isRecording = false;
        }
    }
}