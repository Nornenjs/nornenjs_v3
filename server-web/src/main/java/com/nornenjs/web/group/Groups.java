package com.nornenjs.web.group;

/**
 * Created by Francis on 2015-04-23.
 */
public class Groups {
    
    private Integer pn;
    
    private String groupName;

    private String authority;
    
    public Groups() {
    }

    public Groups(String groupName) {
        this.groupName = groupName;
    }

    public Integer getPn() {
        return pn;
    }

    public void setPn(Integer pn) {
        this.pn = pn;
    }

    public String getGroupName() {
        return groupName;
    }

    public void setGroupName(String groupName) {
        this.groupName = groupName;
    }

    public String getAuthority() {
        return authority;
    }

    public void setAuthority(String authority) {
        this.authority = authority;
    }

    @Override
    public String toString() {
        return "Groups{" +
                "pn=" + pn +
                ", groupName='" + groupName + '\'' +
                ", authority='" + authority + '\'' +
                '}';
    }
}
