namespace LAB3
{
    class Event1
    {
        private string name;
        private int status;
        private int notification;

        public Event1(string name, int status, int notice)
        {
            this.name = name;
            this.status = status;
            this.notification = notice;
        }
        public string getName()
        {
            return name;
        }
        public int getStatus()
        {
            return status;
        }
        public int getNotification()
        {
            return notification;
        }
        public Event1() { }

        public Event1(string name, int status, int notice, Event1 next, Event1 prev)
        {
            this.name = name;
            this.status = status;
            this.notification = notice;
        }
    }

    class Event2
    {
        private string name;
        private int time;
        private int status;
        private int moment;
        public Event2(string name, int status, int time, int moment)
        {
            this.name = name;
            this.time = time;
            this.status = status;
            this.moment = moment;
        }
        public string getName()
        {
            return name;

        }
        public int getStat()
        {
            return status;
        }
        public int getTime()
        {
            return time;
        }
        public int Moment()
        {
            return moment;
        }
        public Event2() { }

        public Event2(string name, int status, int time, int moment, Event2 next, Event2 prev)
        {
            this.name = name;
            this.status = status;
            this.time = time;
            this.moment = moment;
        }
    }
}
