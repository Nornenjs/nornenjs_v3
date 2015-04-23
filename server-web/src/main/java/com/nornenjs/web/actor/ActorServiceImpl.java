package com.nornenjs.web.actor;

import com.nornenjs.web.group.GroupService;
import org.mybatis.spring.support.SqlSessionDaoSupport;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.support.MessageSourceAccessor;
import org.springframework.security.core.GrantedAuthority;
import org.springframework.security.core.authority.AuthorityUtils;
import org.springframework.security.core.userdetails.User;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.stereotype.Service;

import java.util.ArrayList;
import java.util.HashSet;
import java.util.List;
import java.util.Set;

/**
 * Created by Francis on 2015-04-23.
 */
@Service
public class ActorServiceImpl extends SqlSessionDaoSupport implements ActorService, UserDetailsService{

    @Autowired
    private MessageSourceAccessor messages;
    
    @Autowired
    private GroupService groupService;

    // ~ Actor service
    @Override
    public Actor selectOne(Integer pn) {
        return getSqlSession().selectOne("actor.selectOne", pn);
    }

    @Override
    public Integer selectCount(ActorFilter actorFilter) {
        return null;
    }

    @Override
    public List<Actor> selectList(ActorFilter actorFilter) {
        return null;
    }

    @Override
    public Integer insert(Actor actor) {
        return getSqlSession().insert("actor.insert", actor);
    }

    @Override
    public Integer update(Actor actor) {
        return getSqlSession().update("actor.update", actor);
    }

    @Override
    public Integer delete(Integer pn) {
        return getSqlSession().delete("actor.delete", pn);
    }

    // ~ UserDetailService

    /**
     * Allows subclasses to add their own granted authorities to the list to be returned in the <tt>UserDetails</tt>.
     *
     * @param username the username, for use by finder methods
     * @param authorities the current granted authorities, as populated from the <code>authoritiesByUsername</code>
     *        mapping
     */
    protected void addCustomAuthorities(String username, List<GrantedAuthority> authorities) {}
    
    @Override
    public UserDetails loadUserByUsername(String username) throws UsernameNotFoundException {
        List<Actor> actors = selectUsersByUsername(username);
        
        if(actors.size() == 0){
            logger.debug("Query returned no results for user '" + username + "'");
            
            //TODO Need to Change JdbcDaoImpl.notFound
            throw new UsernameNotFoundException(messages.getMessage("JdbcDaoImpl.notFound", new Object[]{username}, "Username {0} not found"));
        }
        
        // ~ select user information
        Actor actor = actors.get(0);
        UserDetails user = new User(actor.getUsername(), actor.getPassword(), actor.getEnabled(), true, true, true, AuthorityUtils.NO_AUTHORITIES);
        
        // ~ Set authority
        Set<GrantedAuthority> dbAuthsSet = new HashSet<GrantedAuthority>();
        dbAuthsSet.addAll(groupService.selectGroupAuthoritiesInfo(user.getUsername()));

        List<GrantedAuthority> dbAuths = new ArrayList<GrantedAuthority>(dbAuthsSet);
        addCustomAuthorities(user.getUsername(), dbAuths);

        if (dbAuths.size() == 0) {
            logger.debug("User '" + username + "' has no authorities and will be treated as 'not found'");

            //TODO Need to Change JdbcDaoImpl.noAuthority
            throw new UsernameNotFoundException(messages.getMessage("JdbcDaoImpl.noAuthority", new Object[] {username}, "User {0} has no GrantedAuthority"));
        }
        
        return createUserDetails(username, user, dbAuths);
    }

    private List<Actor> selectUsersByUsername(String username) {
        List<Actor> actors = getSqlSession().selectList("actor.selectUsersByUsername", username);
        return actors;
    }

    protected UserDetails createUserDetails(String username, UserDetails userFromUserQuery,
                                            List<GrantedAuthority> combinedAuthorities) {
        return new User(username, userFromUserQuery.getPassword(), userFromUserQuery.isEnabled(),
                true, true, true, combinedAuthorities);
    }


}