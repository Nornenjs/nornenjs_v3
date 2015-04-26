package com.nornenjs.test.actor;

import com.nornenjs.web.actor.Actor;
import com.nornenjs.web.actor.ActorFilter;
import com.nornenjs.web.actor.ActorService;
import org.springframework.stereotype.Service;

import java.util.List;

/**
 * Created by Francis on 2015-04-24.
 */
@Service("actorServiceImpl")
public class MockActorServiceImpl implements ActorService{
    
    @Override
    public Actor selectOne(Integer pn) {
        return null;
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
        return null;
    }

    @Override
    public Integer update(Actor actor) {
        return null;
    }

    @Override
    public Integer delete(Integer pn) {
        return null;
    }
}