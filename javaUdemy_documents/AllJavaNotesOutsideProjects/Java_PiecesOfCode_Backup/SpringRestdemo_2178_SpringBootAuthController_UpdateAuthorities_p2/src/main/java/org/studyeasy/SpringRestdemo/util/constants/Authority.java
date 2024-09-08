package org.studyeasy.SpringRestdemo.util.constants;

public enum Authority {
    READ,
    WRITE,
    UPDATE,
    USER,   //CAN UPDATE DELETE SELF OBJECT, READ ANYTHING
    ADMIN   //CAN READ UPDATE DELETE ANY OBJECT
}
