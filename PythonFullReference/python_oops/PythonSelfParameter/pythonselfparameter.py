# The self parameter is a reference to the current instance of the class, and is used to
# access variables that belong to the class.

# It does not have to be named self , you can call it whatever you like, but it has to be the
# first parameter of any function in the class.

class Interview3:
    def __init__(mysillyobj, interviewloc, interviewpos):
        mysillyobj.interviewloc = interviewloc
        mysillyobj.interviewpos = interviewpos

    def interviewFunc(self):
        print("The Interview Location is at : " + self.interviewloc)


pcandid1 = Interview3("Ramagondanahalli", "Non-Voice process")
pcandid1.interviewFunc()