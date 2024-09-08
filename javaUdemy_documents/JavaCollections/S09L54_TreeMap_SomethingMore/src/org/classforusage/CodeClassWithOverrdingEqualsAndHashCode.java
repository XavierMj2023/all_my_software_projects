package org.classforusage;

import java.util.Objects;

public class CodeClassWithOverrdingEqualsAndHashCode implements Comparable<CodeClassWithOverrdingEqualsAndHashCode> {
	private String sectionNo;
	private String lectureNo;
	
	public CodeClassWithOverrdingEqualsAndHashCode(String sectionNo, String lectureNo) {
		this.sectionNo = sectionNo;
		this.lectureNo = lectureNo;
	}

	public String getSectionNo() {
		return sectionNo;
	}

	public String getLectureNo() {
		return lectureNo;
	}

	@Override
	public String toString() {
		return "Code [sectionNo=" + sectionNo + ", lectureNo=" + lectureNo + "]";
	}

	@Override
	public int compareTo(CodeClassWithOverrdingEqualsAndHashCode o) {
		String code1 =  sectionNo.concat(lectureNo);
		String code2 =  o.getSectionNo().concat(o.getLectureNo());
		return code1.compareTo(code2);
	}
	//Overriding HashCode and Equals Method to fix a problem

	@Override
	public int hashCode() {
		return Objects.hash(lectureNo, sectionNo);
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		CodeClassWithOverrdingEqualsAndHashCode other = (CodeClassWithOverrdingEqualsAndHashCode) obj;
		return Objects.equals(lectureNo, other.lectureNo) && Objects.equals(sectionNo, other.sectionNo);
	}
	
}
