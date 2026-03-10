interface IUser{
    userName : string;
    userMail : string;
    getInfo() : string;

}

class User implements IUser{
    public userName : string;
    public userMail : string;
    public registeredDate : Date;

    constructor(userName : string, userMail : string){
        this.userName = userName;
        this.userMail = userMail;
        this.registeredDate = new Date();
    }

    public getInfo():string {
        return `${this.userName} a l'adresse mail : ${this.userMail}`
    }
}

class Guest implements IUser{
    public userName : string;
    public userMail : string;
    
    constructor(userName : string, userMail : string){
        this.userName = userName;
        this.userMail = userMail;
    }
    
    public getInfo():string {
        return `${this.userName} a l'adresse mail : ${this.userMail}`
    }
    
}

//Polymorphisme grâce à l'interface IUser
let userList : IUser[] = [
    new User("Paul", "paul@gmail.com"),
    new User ("Corinne", "corinne@gmail.com"),
    new Guest ("Sarah", "sarah@gmail.com"),
    {
        userMail : "maud@gmail.com",
        userName  : "maud",
        getInfo : function():string
            {
                return "Ohlala"
            }
    }
]