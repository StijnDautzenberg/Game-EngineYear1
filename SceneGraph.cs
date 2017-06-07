﻿using OpenTK;
using System.Collections.Generic;

namespace Template_P3
{
    class SceneGraph
    {
        List<SceneGraphObject> _children;
        List<Camera> _cameras;
        Camera _camera;

        public SceneGraph()
        {
            _children = new List<SceneGraphObject>();
            _cameras = new List<Camera>();
        }

        public void Render(Shader shader)
        {
            foreach(SceneGraphObject o in _children)
            {
                o.Render(shader, _camera.transform.ToWorld);
            }
        }

        public void Add(SceneGraphObject o)
        {
            if(o is Camera)
            {
                _cameras.Add(o as Camera);
                if(_camera == null)
                {
                    _camera = o as Camera;
                }
            }
            _children.Add(o);
        }
    }
}