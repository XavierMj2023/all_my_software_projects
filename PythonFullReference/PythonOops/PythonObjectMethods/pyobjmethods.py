# Objects can also contain methods. Methods in objects are functions that belong to the object.

class Interview2:
    def __init__(self, interviewloc, interviewpos):
        self.interviewloc = interviewloc
        self.interviewpos = interviewpos

    def interviewFunc(self):
        print("The Interview Location is at : " + self.interviewloc)


pcandid1 = Interview2("Whitefield", "Non-Voice process")
pcandid1.interviewFunc()
