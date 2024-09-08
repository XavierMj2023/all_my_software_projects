package org.classforusage;

public class CodeClassUpdated implements Comparable<CodeClassUpdated> {
	private String sectionNo;
	private String lectureNo;
	
	public CodeClassUpdated(String sectionNo, String lectureNo) {
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
	public int compareTo(CodeClassUpdated o) {
		String code1 =  sectionNo.concat(lectureNo);
		String code2 =  o.getSectionNo().concat(o.getLectureNo());
		return code1.compareTo(code2);
	}
}
